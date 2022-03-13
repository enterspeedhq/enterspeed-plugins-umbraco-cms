using System;
using System.IO;
using System.Linq;
using Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.Components.Collections;
using Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.Services
{
    public class SsgConfigurationService : ISsgConfigurationService
    {
        private readonly SsgServiceCollection _ssgServiceCollection;
        private readonly string _configPath = AppDomain.CurrentDomain.BaseDirectory + "/umbraco/Config/Enterspeed.SSG.json";

        public SsgConfigurationService(
            SsgServiceCollection ssgServiceCollection)
        {
            _ssgServiceCollection = ssgServiceCollection;
        }

        public SsgConfiguration Get()
        {
            var configuration = GetConfigurationFromFile();

            if (configuration == null)
            {
                return new SsgConfiguration
                {
                    AvailableServices = _ssgServiceCollection.ToList()
                };
            }

            return new SsgConfiguration
            {
                AvailableServices = _ssgServiceCollection.ToList(),
                ConfiguredServices = configuration.ConfiguredServices
            };
        }

        public void Save(SaveSsgConfigurationDto saveSsgConfigurationDto)
        {
            if (saveSsgConfigurationDto == null)
            {
                return;
            }

            var configurationDto = new SsgConfigurationDto
            {
                ConfiguredServices = saveSsgConfigurationDto.ConfiguredServices
            };

            WriteConfiguration(configurationDto);
        }

        private SsgConfigurationDto GetConfigurationFromFile()
        {
            SsgConfigurationDto config = null;
            if (!File.Exists(_configPath))
            {
                config = new SsgConfigurationDto();
                WriteConfiguration(config);
            }
            else
            {
                config = JsonConvert.DeserializeObject<SsgConfigurationDto>(File.ReadAllText(_configPath));
            }

            return config;
        }

        private void WriteConfiguration(SsgConfigurationDto configuration)
        {
            using (StreamWriter file = File.CreateText(_configPath))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                JObject.FromObject(configuration).WriteTo(writer);
            }
        }
    }
}
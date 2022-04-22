using Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.Models;

namespace Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.Services
{
    public interface ISsgConfigurationService
    {
        SsgConfiguration Get();
        void Save(SaveSsgConfigurationDto saveSsgConfigurationDto);
    }
}
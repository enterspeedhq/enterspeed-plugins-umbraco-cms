using System.Collections.Generic;
using Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.SsgServices.DefaultServices.Netlify;

namespace Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.Models
{
    public class SaveSsgConfigurationDto
    {
        public List<SsgService> AvailableServices { get; set; }

        public Dictionary<string, object> ConfiguredServices { get; set; } = new Dictionary<string, object>();
    }
}
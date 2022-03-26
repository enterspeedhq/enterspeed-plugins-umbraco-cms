using System.Collections.Generic;
using System.Text.Json.Serialization;
using Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.SsgServices;
using Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.SsgServices.DefaultServices.Netlify;

namespace Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.Models
{
    public class SsgConfiguration
    {
        public List<ISsgService> AvailableServices { get; set; }

        public IDictionary<string, object> ConfiguredServices { get; set; } = new Dictionary<string, object>();
    }
}
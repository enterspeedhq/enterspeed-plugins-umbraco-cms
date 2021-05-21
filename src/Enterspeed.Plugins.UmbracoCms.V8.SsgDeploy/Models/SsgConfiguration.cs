using System.Collections.Generic;
using Enterspeed.Plugins.UmbracoCms.V8.SsgDeploy.SsgServices;

namespace Enterspeed.Plugins.UmbracoCms.V8.SsgDeploy.Models
{
    public class SsgConfiguration
    {
        public List<ISsgService> AvailableServices { get; set; }

        public IDictionary<string, object> ConfiguredServices  { get; set; } = new Dictionary<string, object>();
    }
}
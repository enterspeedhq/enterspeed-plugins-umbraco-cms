using System.Collections.Generic;

namespace Enterspeed.Plugins.UmbracoCms.V8.SsgDeploy.Models
{
    public class SsgConfigurationDto
    {
        public IDictionary<string, object> ConfiguredServices { get; set; } = new Dictionary<string, object>();
    }
}
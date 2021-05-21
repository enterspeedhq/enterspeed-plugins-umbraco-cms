using System.Collections.Generic;

namespace Enterspeed.Umbraco.Demo.Web.Core.Models
{
    public class SsgConfigurationDto
    {
        public IDictionary<string, object> ConfiguredServices { get; set; } = new Dictionary<string, object>();
    }
}
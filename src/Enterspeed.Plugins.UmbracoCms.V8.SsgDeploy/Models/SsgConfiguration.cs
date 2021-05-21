using System.Collections.Generic;
using Enterspeed.Umbraco.Demo.Web.Core.SsgServices;

namespace Enterspeed.Umbraco.Demo.Web.Core.Models
{
    public class SsgConfiguration
    {
        public List<ISsgService> AvailableServices { get; set; }

        public IDictionary<string, object> ConfiguredServices  { get; set; } = new Dictionary<string, object>();
    }
}
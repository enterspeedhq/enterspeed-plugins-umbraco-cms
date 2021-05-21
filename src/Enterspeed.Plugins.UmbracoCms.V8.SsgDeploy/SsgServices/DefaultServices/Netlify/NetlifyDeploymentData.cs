using Newtonsoft.Json;

namespace Enterspeed.Plugins.UmbracoCms.V8.SsgDeploy.SsgServices.DefaultServices.Netlify
{
    public class NetlifyDeploymentData
    {
        [JsonProperty("links")]
        public NetlifyLinks Links { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("admin_url")]
        public string AdminUrl { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }
}
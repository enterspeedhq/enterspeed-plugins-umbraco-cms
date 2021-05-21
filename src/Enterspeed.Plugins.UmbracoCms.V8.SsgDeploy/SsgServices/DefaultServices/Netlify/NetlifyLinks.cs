using Newtonsoft.Json;

namespace Enterspeed.Umbraco.Demo.Web.Core.SsgServices.DefaultServices.Netlify
{
    public class NetlifyLinks
    {
        [JsonProperty("permalink")]
        public string PermaLink { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

    }
}
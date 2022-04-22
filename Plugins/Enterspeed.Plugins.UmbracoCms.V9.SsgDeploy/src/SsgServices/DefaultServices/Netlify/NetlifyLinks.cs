﻿using Newtonsoft.Json;

namespace Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.SsgServices.DefaultServices.Netlify
{
    public class NetlifyLinks
    {
        [JsonProperty("permalink")]
        public string PermaLink { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

    }
}
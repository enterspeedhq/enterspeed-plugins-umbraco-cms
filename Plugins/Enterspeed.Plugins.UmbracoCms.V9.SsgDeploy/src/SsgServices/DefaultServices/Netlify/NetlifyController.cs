using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Web.BackOffice.Filters;
using Umbraco.Cms.Web.Common.Controllers;

namespace Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.SsgServices.DefaultServices.Netlify
{
    [JsonCamelCaseFormatter]
    public class NetlifyController : UmbracoApiController
    {
        private readonly NetlifyProgressService _netlifyProgressService;

        public NetlifyController(NetlifyProgressService netlifyProgressService)
        {
            _netlifyProgressService = netlifyProgressService;
        }

        [HttpGet]
        public IDictionary<string, NetlifyProgress> CheckProgress()
        {
            return _netlifyProgressService.Get();
        }

        [HttpPost]
        public bool SetProgress(
            [FromQuery] bool isSuccess,
            [FromBody] NetlifyDeploymentData data)
        {
            var req = Request;
            _netlifyProgressService.SetProgress(data, isSuccess);
            return true;
        }


        [HttpGet]
        public bool Clear()
        {
            _netlifyProgressService.ClearStatus();
            return true;
        }
    }
}
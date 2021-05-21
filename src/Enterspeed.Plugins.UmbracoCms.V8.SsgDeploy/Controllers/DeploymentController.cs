using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Enterspeed.Plugins.UmbracoCms.V8.SsgDeploy.Models;
using Enterspeed.Plugins.UmbracoCms.V8.SsgDeploy.Services;
using Umbraco.Web.WebApi;

namespace Enterspeed.Plugins.UmbracoCms.V8.SsgDeploy.Controllers
{
    [JsonCamelCaseFormatter]
    public class DeploymentController : UmbracoAuthorizedApiController
    {
        private readonly ISsgConfigurationService _configurationService;

        public DeploymentController(ISsgConfigurationService configurationService)
        {
            _configurationService = configurationService;
        }

        [HttpGet]
        public ApiResponse<SsgConfiguration> GetConfiguration()
        {
            return new ApiResponse<SsgConfiguration>()
            {
                IsSuccess = true,
                Data = _configurationService.Get()
            };
        }

        [HttpPost]
        public HttpResponseMessage SaveConfiguration([FromBody] SsgConfiguration configuration)
        {
            try
            {
                _configurationService.Save(configuration);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Success = false,
                    Message = ex.Message,
                    Exception = ex
                });
            }

            return Request.CreateResponse(HttpStatusCode.OK, new
            {
                StatusCode = HttpStatusCode.OK,
                Success = true
            });
        }
    }
}
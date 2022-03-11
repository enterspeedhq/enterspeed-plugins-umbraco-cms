using System;
using System.Net;
using Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.Models;
using Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.Services;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Web.BackOffice.Controllers;
using Umbraco.Cms.Web.BackOffice.Filters;

namespace Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.Controllers
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
        public IActionResult SaveConfiguration([FromBody] SsgConfiguration configuration)
        {
            try
            {
                _configurationService.Save(configuration);
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Success = false,
                    Message = ex.Message,
                    Exception = ex
                });
            }

            return Ok(new
            {
                StatusCode = HttpStatusCode.OK,
                Success = true
            });
        }
    }
}
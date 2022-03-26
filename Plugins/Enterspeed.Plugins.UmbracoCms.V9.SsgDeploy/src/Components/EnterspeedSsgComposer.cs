using Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.Components.Collections;
using Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.Services;
using Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.SsgServices.DefaultServices.Netlify;
using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

namespace Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.Components
{
    public class EnterspeedSsgComposer : IComposer
    {
        public void Compose(IUmbracoBuilder builder)
        {
            builder.Services.AddSingleton<NetlifyProgressService>();

            builder.Services.AddTransient<ISsgConfigurationService, SsgConfigurationService>();
            builder.SsgServices().Append<NetlifySsgService>();
        }
    }
}
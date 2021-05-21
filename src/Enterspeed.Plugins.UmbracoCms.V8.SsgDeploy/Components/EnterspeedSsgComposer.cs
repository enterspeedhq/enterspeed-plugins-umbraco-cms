using Enterspeed.Plugins.UmbracoCms.V8.SsgDeploy.Components.Collections;
using Enterspeed.Plugins.UmbracoCms.V8.SsgDeploy.Services;
using Enterspeed.Plugins.UmbracoCms.V8.SsgDeploy.SsgServices.DefaultServices.Netlify;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace Enterspeed.Plugins.UmbracoCms.V8.SsgDeploy.Components
{
    public class EnterspeedSsgComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<NetlifyProgressService>(Lifetime.Singleton);

            composition.Register<ISsgConfigurationService, SsgConfigurationService>();

            composition.SsgServices()
                .Append<NetlifySsgService>();
        }
    }
}
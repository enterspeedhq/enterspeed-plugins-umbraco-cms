using Enterspeed.Umbraco.Demo.Web.Core.Components.Collections;
using Enterspeed.Umbraco.Demo.Web.Core.Services;
using Enterspeed.Umbraco.Demo.Web.Core.SsgServices;
using Enterspeed.Umbraco.Demo.Web.Core.SsgServices.DefaultServices.Netlify;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace Enterspeed.Umbraco.Demo.Web.Core.Components
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
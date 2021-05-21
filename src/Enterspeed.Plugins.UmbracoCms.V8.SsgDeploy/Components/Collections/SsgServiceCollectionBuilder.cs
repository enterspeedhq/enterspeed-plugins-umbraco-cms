using Enterspeed.Plugins.UmbracoCms.V8.SsgDeploy.SsgServices;
using Umbraco.Core.Composing;

namespace Enterspeed.Plugins.UmbracoCms.V8.SsgDeploy.Components.Collections
{
    public class SsgServiceCollectionBuilder : OrderedCollectionBuilderBase<SsgServiceCollectionBuilder, SsgServiceCollection, ISsgService>
    {
        protected override SsgServiceCollectionBuilder This => this;
    }
}
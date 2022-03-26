using Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.SsgServices;
using Umbraco.Cms.Core.Composing;

namespace Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.Components.Collections
{
    public class SsgServiceCollectionBuilder : OrderedCollectionBuilderBase<SsgServiceCollectionBuilder, SsgServiceCollection, ISsgService>
    {
        protected override SsgServiceCollectionBuilder This => this;
    }
}
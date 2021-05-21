using Enterspeed.Umbraco.Demo.Web.Core.SsgServices;
using Umbraco.Core.Composing;

namespace Enterspeed.Umbraco.Demo.Web.Core.Components.Collections
{
    public class SsgServiceCollectionBuilder : OrderedCollectionBuilderBase<SsgServiceCollectionBuilder, SsgServiceCollection, ISsgService>
    {
        protected override SsgServiceCollectionBuilder This => this;
    }
}
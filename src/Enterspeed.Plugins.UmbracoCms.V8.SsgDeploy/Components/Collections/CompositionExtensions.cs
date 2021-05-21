using Umbraco.Core.Composing;

namespace Enterspeed.Umbraco.Demo.Web.Core.Components.Collections
{
    public static class CompositionExtensions
    {
        public static SsgServiceCollectionBuilder SsgServices(this Composition composition)
            => composition.WithCollectionBuilder<SsgServiceCollectionBuilder>();
    }
}
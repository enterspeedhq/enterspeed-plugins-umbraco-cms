using Umbraco.Core.Composing;

namespace Enterspeed.Plugins.UmbracoCms.V8.SsgDeploy.Components.Collections
{
    public static class CompositionExtensions
    {
        public static SsgServiceCollectionBuilder SsgServices(this Composition composition)
            => composition.WithCollectionBuilder<SsgServiceCollectionBuilder>();
    }
}
using Umbraco.Cms.Core.DependencyInjection;

namespace Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.Components.Collections
{
    public static class CompositionExtensions
    {
        public static SsgServiceCollectionBuilder SsgServices(this IUmbracoBuilder builder)
            => builder.WithCollectionBuilder<SsgServiceCollectionBuilder>();
    }
}
using System.Collections.Generic;
using Enterspeed.Plugins.UmbracoCms.V8.SsgDeploy.SsgServices;
using Umbraco.Core.Composing;

namespace Enterspeed.Plugins.UmbracoCms.V8.SsgDeploy.Components.Collections
{
    public class SsgServiceCollection : BuilderCollectionBase<ISsgService>
    {
        public SsgServiceCollection(IEnumerable<ISsgService> items)
            : base(items)
        {
        }
    }
}
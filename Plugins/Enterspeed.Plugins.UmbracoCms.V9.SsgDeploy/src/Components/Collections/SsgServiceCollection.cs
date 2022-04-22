using System;
using System.Collections.Generic;
using Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.SsgServices;
using Umbraco.Cms.Core.Composing;

namespace Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.Components.Collections
{
    public class SsgServiceCollection : BuilderCollectionBase<ISsgService>
    {
        public SsgServiceCollection(Func<IEnumerable<ISsgService>> items)
            : base(items)
        {
        }
    }
}
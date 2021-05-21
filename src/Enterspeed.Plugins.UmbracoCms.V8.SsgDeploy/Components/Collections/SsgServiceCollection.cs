using System.Collections.Generic;
using Enterspeed.Umbraco.Demo.Web.Core.Models;
using Enterspeed.Umbraco.Demo.Web.Core.SsgServices;
using Umbraco.Core.Composing;

namespace Enterspeed.Umbraco.Demo.Web.Core.Components.Collections
{
    public class SsgServiceCollection : BuilderCollectionBase<ISsgService>
    {
        public SsgServiceCollection(IEnumerable<ISsgService> items)
            : base(items)
        {
        }
    }
}
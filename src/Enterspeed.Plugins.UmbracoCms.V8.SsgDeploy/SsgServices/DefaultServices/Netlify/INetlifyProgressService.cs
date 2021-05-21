using System.Collections.Generic;

namespace Enterspeed.Umbraco.Demo.Web.Core.SsgServices.DefaultServices.Netlify
{
    public interface INetlifyProgressService
    {
        void SetProgress(NetlifyDeploymentData data, bool isSuccess);
        void ClearStatus();
        IDictionary<string, NetlifyProgress> Get();
    }
}
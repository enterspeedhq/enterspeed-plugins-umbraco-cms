using System.Collections.Generic;

namespace Enterspeed.Plugins.UmbracoCms.V8.SsgDeploy.SsgServices.DefaultServices.Netlify
{
    public interface INetlifyProgressService
    {
        void SetProgress(NetlifyDeploymentData data, bool isSuccess);
        void ClearStatus();
        IDictionary<string, NetlifyProgress> Get();
    }
}
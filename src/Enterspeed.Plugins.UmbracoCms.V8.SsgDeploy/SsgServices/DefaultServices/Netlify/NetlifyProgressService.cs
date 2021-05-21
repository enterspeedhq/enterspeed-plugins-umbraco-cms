using System.Collections.Generic;
using System.Linq;

namespace Enterspeed.Plugins.UmbracoCms.V8.SsgDeploy.SsgServices.DefaultServices.Netlify
{
    public class NetlifyProgressService : INetlifyProgressService
    {
        private IDictionary<string, NetlifyProgress> Progress { get; } = new Dictionary<string, NetlifyProgress>()
        {
            ["requested"] = new NetlifyProgress()
            {
                Name = "Deploy requested",
                Alias = "deployedRequested"
            },
            ["building"] = new NetlifyProgress()
            {
                Name = "Deploy started",
                Alias = "deployStarted"
            },
            ["ready"] = new NetlifyProgress()
            {
                Name = "Deploy finished",
                Alias = "deployFinished"
            }
        };


        public void SetProgress(
            NetlifyDeploymentData data,
            bool isSuccess)
        {
            if (data.State == Progress.Keys.First())
            {
                ClearStatus();
            }

            Progress[data.State].Succeeded = isSuccess;
            Progress[data.State].DeploymentData = data;
            Progress[data.State].HasExecuted = true;
        }

        public void ClearStatus()
        {
            foreach (var progress in Progress)
            {
                progress.Value.Succeeded = false;
                progress.Value.HasExecuted = false;
                progress.Value.DeploymentData = null;
            }
        }

        public IDictionary<string, NetlifyProgress> Get()
        {
            return Progress;
        }
    }
}
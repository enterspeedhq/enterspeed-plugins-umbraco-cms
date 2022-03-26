namespace Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.SsgServices.DefaultServices.Netlify
{
    public class NetlifyProgress
    {
        public string Name { get; set; }
        public string Alias { get; set; }
        public bool Succeeded { get; set; }
        public bool HasExecuted { get; set; }

        public NetlifyDeploymentData DeploymentData { get; set; }
    }
}
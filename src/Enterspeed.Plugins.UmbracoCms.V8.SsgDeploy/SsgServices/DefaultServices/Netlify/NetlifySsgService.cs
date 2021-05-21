namespace Enterspeed.Plugins.UmbracoCms.V8.SsgDeploy.SsgServices.DefaultServices.Netlify
{
    public class NetlifySsgService : ISsgService
    {
        public string Alias => "netlify";
        public string Name => "Netlify";
        public string ConfigurationView => "/App_Plugins/Enterspeed.Deploy.SSG/Services/Netlify/netlify-configuration.view.html";
        public string ContentView => "/App_Plugins/Enterspeed.Deploy.SSG/Services/Netlify/netlify-content.view.html";

        /*
         * Configurations
         * 
         */
        public string DeploymentUrl { get; set; }
    }
}
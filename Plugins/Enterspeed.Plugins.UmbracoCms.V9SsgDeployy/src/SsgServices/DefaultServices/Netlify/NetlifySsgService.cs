namespace Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.SsgServices.DefaultServices.Netlify
{
    public class NetlifySsgService : SsgService, ISsgService
    {
        public override string Alias => "netlify";
        public override string Name => "Netlify";
        public override string ConfigurationView => "/App_Plugins/Enterspeed.Deploy.SSG/Services/Netlify/netlify-configuration.view.html";
        public override string ContentView => "/App_Plugins/Enterspeed.Deploy.SSG/Services/Netlify/netlify-content.view.html";

        /*
         * Configurations
         * 
         */
        public string DeploymentUrl { get; set; }
    }
}
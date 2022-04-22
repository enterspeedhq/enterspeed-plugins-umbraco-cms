using System;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.Dashboards;

namespace Enterspeed.Plugins.UmbracoCms.V9.SsgDeploy.Dashboard
{
    [Weight(31)]
    public class EnterspeedSsgSettingsDashboard : IDashboard
    {
        public string Alias => "enterspeedSsgSettingsDashboard";
        public string View => "/App_Plugins/Enterspeed.Deploy.SSG/settings-dashboard.html";
        public string[] Sections => new[] { "Settings" };

        public IAccessRule[] AccessRules => Array.Empty<IAccessRule>();
    }
}
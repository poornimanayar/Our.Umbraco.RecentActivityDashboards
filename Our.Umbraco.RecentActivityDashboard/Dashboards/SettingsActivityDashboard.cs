using System;
using Umbraco.Core.Composing;
using Umbraco.Core.Dashboards;

namespace Our.Umbraco.RecentActivityDashboard.Dashboards
{
    [Weight(15)]
   public class SettingsActivityDashboard : IDashboard
   {
       public string Alias => "Our.Umbraco.SettingsActivityDashboard";
       public string View => "/App_Plugins/Our.Umbraco.RecentActivityDashboard/views/SettingsActivityDashboard.html";
        public string[] Sections => new[]
        {
            global::Umbraco.Core.Constants.Applications.Settings
        };

        public IAccessRule[] AccessRules => Array.Empty<IAccessRule>();
    }
}

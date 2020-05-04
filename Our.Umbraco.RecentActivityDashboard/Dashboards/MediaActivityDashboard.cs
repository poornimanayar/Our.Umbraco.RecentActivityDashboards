using System;
using Umbraco.Core.Composing;
using Umbraco.Core.Dashboards;

namespace Our.Umbraco.ContentDashboard.Dashboards
{
    [Weight(15)]
   public class MediaActivityDashboard : IDashboard
   {
       public string Alias => "Our.Umbraco.MediaActivityDashboard";
       public string View => "/App_Plugins/Our.Umbraco.RecentActivityDashboard/views/MediaActivityDashboard.html";
        public string[] Sections => new[]
        {
            global::Umbraco.Core.Constants.Applications.Media
        };

        public IAccessRule[] AccessRules => Array.Empty<IAccessRule>();
    }
}

using System;
using Umbraco.Core.Composing;
using Umbraco.Core.Dashboards;

namespace Our.Umbraco.RecentActivityDashboard.Dashboards
{
    [Weight(-10)]
    public class ContentActivityDashboard : IDashboard
    {
        public string Alias => "Our.Umbraco.ContentActivityDashboard";
        public string View => "/App_Plugins/Our.Umbraco.RecentActivityDashboard/views/ContentActivityDashboard.html";

        public string[] Sections => new[]
        {
            global::Umbraco.Core.Constants.Applications.Content
        };

        public IAccessRule[] AccessRules => Array.Empty<IAccessRule>();
    }
}



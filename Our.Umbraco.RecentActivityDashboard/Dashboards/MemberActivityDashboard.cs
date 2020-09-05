using System;
using Umbraco.Core.Composing;
using Umbraco.Core.Dashboards;

namespace Our.Umbraco.RecentActivityDashboard.Dashboards
{
    [Weight(-10)]
   public class MemberActivityDashboard : IDashboard
   {
       public string Alias => "Our.Umbraco.MemberActivityDashboard";
       public string View => "/App_Plugins/Our.Umbraco.RecentActivityDashboard/views/MemberActivityDashboard.html";
        public string[] Sections => new[]
        {
            global::Umbraco.Core.Constants.Applications.Members
        };

        public IAccessRule[] AccessRules => Array.Empty<IAccessRule>();
    }
}

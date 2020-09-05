using Our.Umbraco.RecentActivityDashboard.Services;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace Our.Umbraco.RecentActivityDashboard.Composing
{
   public class DashboardComposer :IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<IDashboardLogService, DashboardLogService>();
        }
    }
}

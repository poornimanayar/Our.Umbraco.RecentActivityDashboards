using Our.Umbraco.ContentDashboard.Services;
using Umbraco.Core;
using Umbraco.Core.Composing;

namespace Our.Umbraco.ContentDashboard.Composing
{
   public class DashboardComposer :IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<IDashboardLogService, DashboardLogService>();
        }
    }
}

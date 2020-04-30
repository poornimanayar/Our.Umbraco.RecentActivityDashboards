using System;
using System.Collections.Generic;
using Our.Umbraco.ContentDashboard.Constants;
using Our.Umbraco.ContentDashboard.Models;
using Our.Umbraco.ContentDashboard.Services;
using Umbraco.Web.Editors;
using Umbraco.Web.Mvc;

namespace Our.Umbraco.ContentDashboard.Controllers
{
    [PluginController("OurUmbracoActivityDashboard")]
    public class ContentActivityApiController : UmbracoAuthorizedJsonController
    {
        private readonly IDashboardLogService _dashboardLogService;

        private DateTime sinceDate = DateTime.Now.Subtract(new TimeSpan(days: 1, 0, 0, 0));

        public ContentActivityApiController(IDashboardLogService dashboardLogService)
        {
            _dashboardLogService = dashboardLogService;
        }


        public List<LogItem> GetDocumentLogs()
        {
            return _dashboardLogService.GetLogs(DashboardConstants.DocumentLogHeader,
                DashboardConstants.DocumentEntityType, sinceDate);
        }

        public List<LogItem> GetMediaLogs()
        {
            return _dashboardLogService.GetLogs(DashboardConstants.MediaLogHeader,
                DashboardConstants.MediaEntityType, sinceDate);
        }

        public List<LogItem> GetSettingsLogs()
        {
            return _dashboardLogService.GetLogs(DashboardConstants.SettingsLogHeader,
                DashboardConstants.SettingsEntityType, DateTime.Now.Subtract(new TimeSpan(days: 30, 0, 0, 0)));
        }

        public List<LogItem> GetMemberLogs()
        {
            return _dashboardLogService.GetLogs(DashboardConstants.MemberLogHeader,
                DashboardConstants.MemberEntityType, sinceDate);
        }

    }
}
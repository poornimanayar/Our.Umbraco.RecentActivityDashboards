using System;
using System.Collections.Generic;
using Our.Umbraco.RecentActivityDashboard.Constants;
using Our.Umbraco.RecentActivityDashboard.Models;
using Our.Umbraco.RecentActivityDashboard.Services;
using Umbraco.Core.Logging;
using Umbraco.Web.Editors;
using Umbraco.Web.Mvc;

namespace Our.Umbraco.RecentActivityDashboard.Controllers
{
    [PluginController("OurUmbracoActivityDashboard")]
    public class ContentActivityApiController : UmbracoAuthorizedJsonController
    {
        private readonly IDashboardLogService _dashboardLogService;

        private readonly ILogger _logger;

        private DateTime sinceDate = DateTime.Now.Subtract(new TimeSpan(days: 1, 0, 0, 0));

        public ContentActivityApiController(IDashboardLogService dashboardLogService, ILogger logger)
        {
            _dashboardLogService = dashboardLogService;
            _logger = logger;
        }


        public List<LogItem> GetDocumentLogs()
        {
            try
            {
                return _dashboardLogService.GetLogs(DashboardConstants.DocumentLogHeader,
                    DashboardConstants.DocumentEntityType, sinceDate);
            }
            catch (Exception ex)
            {
                _logger.Error<ContentActivityApiController>(ex.ToString());
                return null;
            }
          
        }

        public List<LogItem> GetMediaLogs()
        {
            try
            {
                return _dashboardLogService.GetLogs(DashboardConstants.MediaLogHeader,
                    DashboardConstants.MediaEntityType, sinceDate);
            }
            catch (Exception ex)
            {
                _logger.Error<ContentActivityApiController>(ex.ToString());
                return null;
            }
        }

        public List<LogItem> GetSettingsLogs()
        {
            try
            {
                return _dashboardLogService.GetLogs(DashboardConstants.SettingsLogHeader,
                    DashboardConstants.SettingsEntityType, DateTime.Now.Subtract(new TimeSpan(days: 30, 0, 0, 0)));
            }
            catch (Exception ex)
            {
                _logger.Error<ContentActivityApiController>(ex.ToString());
                return null;
            }
        }

        public List<LogItem> GetMemberLogs()
        {
            try
            {
                return _dashboardLogService.GetLogs(DashboardConstants.MemberLogHeader,
                    DashboardConstants.MemberEntityType, sinceDate);
            }
            catch (Exception ex)
            {
                _logger.Error<ContentActivityApiController>(ex.ToString());
                return null;
            }
        }

    }
}
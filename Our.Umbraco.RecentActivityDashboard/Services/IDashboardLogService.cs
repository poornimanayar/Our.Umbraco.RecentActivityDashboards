using System;
using System.Collections.Generic;
using Our.Umbraco.RecentActivityDashboard.Models;

namespace Our.Umbraco.RecentActivityDashboard.Services
{
   public interface IDashboardLogService
   {
       List<LogItem> GetLogs(string[] logHeader, string[] entityType, DateTime sinceDate);
   }
}

using System;
using System.Collections.Generic;
using Our.Umbraco.ContentDashboard.Models;

namespace Our.Umbraco.ContentDashboard.Services
{
   public interface IDashboardLogService
   {
       List<LogItem> GetLogs(string[] logHeader, string[] entityType, DateTime sinceDate);
   }
}

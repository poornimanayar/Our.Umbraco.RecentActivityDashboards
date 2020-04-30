using System;

namespace Our.Umbraco.ContentDashboard.Models
{
    public class LogItem
    {
        public int NodeId { get; set; }

        public int? UserId { get; set; }

        public string Action { get; set; }

        public string DateStamp { get; set; }

        public string EntityType { get; set; }
        public string NodeName { get; set; }

        public string UserName { get; set; }
        public string EditUrl { get; internal set; }
        public string Icon { get; internal set; }
    }
}
using System;

namespace Our.Umbraco.ContentDashboard.Models
{
    public class LogDto
    {
       public int Id { get; set; }

        public int? UserId { get; set; }

        public int NodeId { get; set; }

        public string EntityType { get; set; }

        // TODO: Should we have an index on this since we allow searching on it?
        public DateTime Datestamp { get; set; }

        // TODO: Should we have an index on this since we allow searching on it?
       public string LogHeader { get; set; }

        public string Comment { get; set; }

        /// <summary>
        /// Used to store additional data parameters for the log
        /// </summary>
       public string Parameters { get; set; }
    }
}
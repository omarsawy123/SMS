using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpTimeZones
    {
        public int TimeZoneId { get; set; }
        public string DisplayName { get; set; }
        public int TimeZoneValue { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
    }
}

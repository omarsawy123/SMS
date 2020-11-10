using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpDateFormats
    {
        public int DateFormatId { get; set; }
        public string DisplayName { get; set; }
        public string DateFormat { get; set; }
        public int DateCode { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
    }
}

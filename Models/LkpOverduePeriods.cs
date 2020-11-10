using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpOverduePeriods
    {
        public int OverduePeriodId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int? FromDay { get; set; }
        public int? ToDay { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
    }
}

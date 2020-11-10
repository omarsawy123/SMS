using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpMonths
    {
        public LkpMonths()
        {
            TblAccJournals = new HashSet<TblAccJournals>();
        }

        public int MonthId { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<TblAccJournals> TblAccJournals { get; set; }
    }
}

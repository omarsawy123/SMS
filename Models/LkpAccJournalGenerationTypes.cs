using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpAccJournalGenerationTypes
    {
        public LkpAccJournalGenerationTypes()
        {
            TblAccJournals = new HashSet<TblAccJournals>();
        }

        public int JournalGenerationTypeId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public string ReporDisplayNameEn { get; set; }
        public string ReportDisplayNameAr { get; set; }
        public bool? IsAp { get; set; }
        public bool? IsAr { get; set; }

        public virtual ICollection<TblAccJournals> TblAccJournals { get; set; }
    }
}

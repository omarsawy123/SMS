using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpReportHeaders
    {
        public LkpReportHeaders()
        {
            LkpReportsDegreeFunctions = new HashSet<LkpReportsDegreeFunctions>();
            LkpReportsHeaderSemesters = new HashSet<LkpReportsHeaderSemesters>();
            LkpReportsSecretaryFunctions = new HashSet<LkpReportsSecretaryFunctions>();
        }

        public int ReportHeaderId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string Header1 { get; set; }
        public string Header1Ar { get; set; }
        public string Header2 { get; set; }
        public string Header2Ar { get; set; }
        public string Header3 { get; set; }
        public string Header3Ar { get; set; }
        public string Footer1 { get; set; }
        public string Footer1Ar { get; set; }
        public string Footer2 { get; set; }
        public string Footer2Ar { get; set; }
        public string FormNumber { get; set; }
        public bool ShowHeaders { get; set; }
        public bool ShowFooters { get; set; }
        public bool ShowLogo { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public string NameFr { get; set; }
        public string Header1Fr { get; set; }
        public string Header2Fr { get; set; }
        public string Header3Fr { get; set; }
        public string Footer1Fr { get; set; }
        public string Footer2Fr { get; set; }
        public bool ShowPanner { get; set; }

        public virtual ICollection<LkpReportsDegreeFunctions> LkpReportsDegreeFunctions { get; set; }
        public virtual ICollection<LkpReportsHeaderSemesters> LkpReportsHeaderSemesters { get; set; }
        public virtual ICollection<LkpReportsSecretaryFunctions> LkpReportsSecretaryFunctions { get; set; }
    }
}

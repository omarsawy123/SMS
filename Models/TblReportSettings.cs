using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblReportSettings
    {
        public int ReportSettingId { get; set; }
        public string Header1 { get; set; }
        public string Header1Ar { get; set; }
        public string Header2 { get; set; }
        public string Header2Ar { get; set; }
        public string Header3 { get; set; }
        public string Header3Ar { get; set; }
        public string LogoPath { get; set; }
        public string Body1 { get; set; }
        public string Body2 { get; set; }
        public string Footer1 { get; set; }
        public string Footer1Ar { get; set; }
        public string Footer2 { get; set; }
        public string Footer2Ar { get; set; }
        public int? CreatorUserId { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? ModifiedUserId { get; set; }
        public DateTime? LastDateModified { get; set; }
        public bool? IsDeleted { get; set; }
    }
}

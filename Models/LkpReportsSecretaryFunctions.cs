using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpReportsSecretaryFunctions
    {
        public int ReportsSecretaryFunctionId { get; set; }
        public string NameFr { get; set; }
        public string NameAr { get; set; }
        public string FunctionUrl { get; set; }
        public string Stages { get; set; }
        public string Grades { get; set; }
        public bool IsDefault { get; set; }
        public int ReportHeaderId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public bool? EnableReligion { get; set; }
        public bool? EnableStudentStatus { get; set; }
        public string Sections { get; set; }
        public string NameEn { get; set; }

        public virtual LkpReportHeaders ReportHeader { get; set; }
    }
}

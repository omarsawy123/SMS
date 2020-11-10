using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpReportsHeaderSemesters
    {
        public int ReportsHeaderSemesterId { get; set; }
        public int ReportHeaderId { get; set; }
        public int SemesterId { get; set; }
        public string ReportTitle { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpReportHeaders ReportHeader { get; set; }
        public virtual LkpSemesters Semester { get; set; }
    }
}

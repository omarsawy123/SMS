using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblRptReports
    {
        public TblRptReports()
        {
            TblRptReportDataSources = new HashSet<TblRptReportDataSources>();
        }

        public int ReportId { get; set; }
        public string Name { get; set; }
        public double Pagewidth { get; set; }
        public double PageHeight { get; set; }
        public string ResourceKey { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblRptReportDataSources> TblRptReportDataSources { get; set; }
    }
}

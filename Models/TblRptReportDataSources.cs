using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblRptReportDataSources
    {
        public int ReportId { get; set; }
        public int DataSourceId { get; set; }
        public int SequenceOrder { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblRptDatasources DataSource { get; set; }
        public virtual TblRptReports Report { get; set; }
    }
}

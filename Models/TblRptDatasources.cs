using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblRptDatasources
    {
        public TblRptDatasources()
        {
            TblRptDatasourceFields = new HashSet<TblRptDatasourceFields>();
            TblRptReportDataSources = new HashSet<TblRptReportDataSources>();
            TblRptSpparameters = new HashSet<TblRptSpparameters>();
        }

        public int DatasourceId { get; set; }
        public string DisplayName { get; set; }
        public string Name { get; set; }
        public int DataSourceTypeId { get; set; }
        public decimal RowHeight { get; set; }
        public string GroupBy { get; set; }
        public string ResourceKey { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblRptDatasourceTypes DataSourceType { get; set; }
        public virtual ICollection<TblRptDatasourceFields> TblRptDatasourceFields { get; set; }
        public virtual ICollection<TblRptReportDataSources> TblRptReportDataSources { get; set; }
        public virtual ICollection<TblRptSpparameters> TblRptSpparameters { get; set; }
    }
}

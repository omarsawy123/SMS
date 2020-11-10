using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblRptSpparameters
    {
        public int SpparameterId { get; set; }
        public int DatasourceId { get; set; }
        public string Name { get; set; }
        public string DataType { get; set; }
        public string LookupField { get; set; }
        public bool IsMandatory { get; set; }
        public bool IsMultipleSelection { get; set; }
        public string ResourceKey { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblRptDatasources Datasource { get; set; }
    }
}

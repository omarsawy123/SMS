using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblRptDatasourceTypes
    {
        public TblRptDatasourceTypes()
        {
            TblRptDatasources = new HashSet<TblRptDatasources>();
        }

        public int DatasourceTypeId { get; set; }
        public string Name { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblRptDatasources> TblRptDatasources { get; set; }
    }
}

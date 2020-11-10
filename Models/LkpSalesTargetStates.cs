using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpSalesTargetStates
    {
        public LkpSalesTargetStates()
        {
            TblClientSalesTargets = new HashSet<TblClientSalesTargets>();
        }

        public int SalesTargetStatusId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblClientSalesTargets> TblClientSalesTargets { get; set; }
    }
}

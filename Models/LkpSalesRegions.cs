using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpSalesRegions
    {
        public LkpSalesRegions()
        {
            TblClients = new HashSet<TblClients>();
            TblUsers = new HashSet<TblUsers>();
        }

        public int SalesRegionId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblClients> TblClients { get; set; }
        public virtual ICollection<TblUsers> TblUsers { get; set; }
    }
}

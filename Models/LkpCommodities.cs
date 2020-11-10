using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpCommodities
    {
        public LkpCommodities()
        {
            TblClientRateAgreements = new HashSet<TblClientRateAgreements>();
            TblClientSalesTargets = new HashSet<TblClientSalesTargets>();
            TblServicePrices = new HashSet<TblServicePrices>();
        }

        public int CommodityId { get; set; }
        public string Code { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblClientRateAgreements> TblClientRateAgreements { get; set; }
        public virtual ICollection<TblClientSalesTargets> TblClientSalesTargets { get; set; }
        public virtual ICollection<TblServicePrices> TblServicePrices { get; set; }
    }
}

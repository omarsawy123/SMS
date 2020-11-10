using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblPricingListTransitPorts
    {
        public int PricingListTransitPortId { get; set; }
        public int TransitPortId { get; set; }
        public decimal TransitPeriodInHours { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int TransitOrder { get; set; }
        public int PricingListPriceId { get; set; }

        public virtual TblPricingListPrices PricingListPrice { get; set; }
        public virtual LkpPorts TransitPort { get; set; }
    }
}

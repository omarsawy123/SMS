using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblPricingListPrices
    {
        public TblPricingListPrices()
        {
            TblPricingListTransitPorts = new HashSet<TblPricingListTransitPorts>();
        }

        public int PricingListPriceId { get; set; }
        public int PricingListId { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellPrice { get; set; }
        public int CurrencyId { get; set; }
        public int CostCurrencyId { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public string FrequencyOfService { get; set; }
        public decimal TransitTime { get; set; }
        public DateTime? VaildFrom { get; set; }
        public DateTime? VaildTo { get; set; }
        public int ServiceProviderId { get; set; }
        public bool? IsActive { get; set; }
        public bool IsTransitTimeInHours { get; set; }
        public int TransitTypeId { get; set; }

        public virtual LkpCurrencies CostCurrency { get; set; }
        public virtual LkpCurrencies Currency { get; set; }
        public virtual TblPricingLists PricingList { get; set; }
        public virtual TblServiceProviders ServiceProvider { get; set; }
        public virtual LkpTransitTypes TransitType { get; set; }
        public virtual ICollection<TblPricingListTransitPorts> TblPricingListTransitPorts { get; set; }
    }
}

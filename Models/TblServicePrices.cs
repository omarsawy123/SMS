using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblServicePrices
    {
        public int ServicePriceId { get; set; }
        public int ServiceId { get; set; }
        public int PortId { get; set; }
        public int? ClientId { get; set; }
        public int? ServiceProviderId { get; set; }
        public int? CommodityId { get; set; }
        public int? BookingTypeId { get; set; }
        public decimal SellPrice { get; set; }
        public int CurrencyId { get; set; }
        public decimal CostPrice { get; set; }
        public int CostCurrencyId { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpBookingTypes BookingType { get; set; }
        public virtual TblClients Client { get; set; }
        public virtual LkpCommodities Commodity { get; set; }
        public virtual LkpCurrencies CostCurrency { get; set; }
        public virtual LkpCurrencies Currency { get; set; }
        public virtual LkpPorts Port { get; set; }
        public virtual LkpServices Service { get; set; }
        public virtual TblServiceProviders ServiceProvider { get; set; }
    }
}

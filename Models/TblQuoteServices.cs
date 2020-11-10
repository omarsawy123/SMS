using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblQuoteServices
    {
        public int QuoteServiceId { get; set; }
        public int QuoteId { get; set; }
        public int ServiceId { get; set; }
        public string Description { get; set; }
        public decimal SellPrice { get; set; }
        public int CurrencyId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int? ServiceProviderId { get; set; }

        public virtual LkpCurrencies Currency { get; set; }
        public virtual TblQuotes Quote { get; set; }
        public virtual LkpServices Service { get; set; }
        public virtual TblServiceProviders ServiceProvider { get; set; }
    }
}

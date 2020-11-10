using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblAccExchangeRates
    {
        public int ExchangeRateId { get; set; }
        public int FromCurrencyId { get; set; }
        public int ToCurrencyId { get; set; }
        public DateTime ValidFrom { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool? IsActive { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpCurrencies FromCurrency { get; set; }
        public virtual LkpCurrencies ToCurrency { get; set; }
    }
}

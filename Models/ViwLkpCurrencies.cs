using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class ViwLkpCurrencies
    {
        public int CurrencyId { get; set; }
        public string Code { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string CurrNameEn { get; set; }
        public string CurrNameAr { get; set; }
        public bool IsDeleted { get; set; }
    }
}

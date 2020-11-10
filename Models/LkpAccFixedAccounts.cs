using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpAccFixedAccounts
    {
        public LkpAccFixedAccounts()
        {
            TblAccAccountCurrencyLinks = new HashSet<TblAccAccountCurrencyLinks>();
        }

        public int FixedAccountId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public bool CheckInInvoices { get; set; }
        public bool CheckInPayments { get; set; }
        public decimal? DiscountPercent { get; set; }
        public bool HasMultiCurrencies { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblAccAccountLinks TblAccAccountLinks { get; set; }
        public virtual ICollection<TblAccAccountCurrencyLinks> TblAccAccountCurrencyLinks { get; set; }
    }
}

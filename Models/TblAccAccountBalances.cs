using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblAccAccountBalances
    {
        public int AccountBalanceId { get; set; }
        public int AccountId { get; set; }
        public int FinancialYearId { get; set; }
        public decimal Amount { get; set; }
        public int CurrencyId { get; set; }
        public decimal LocalCurrencyAmount { get; set; }
        public string Description { get; set; }
        public int? ClientId { get; set; }
        public int? SupplierId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblAccAccounts Account { get; set; }
        public virtual TblClients Client { get; set; }
        public virtual LkpCurrencies Currency { get; set; }
        public virtual LkpFinancialYears FinancialYear { get; set; }
        public virtual TblServiceProviders Supplier { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblAccAccounts
    {
        public TblAccAccounts()
        {
            InverseParentAccount = new HashSet<TblAccAccounts>();
            LkpAccTreasuryCurrencies = new HashSet<LkpAccTreasuryCurrencies>();
            LkpBankAccounts = new HashSet<LkpBankAccounts>();
            LkpExpensesTypeActivities = new HashSet<LkpExpensesTypeActivities>();
            LkpInvoiceTypeCurrenciesAccount = new HashSet<LkpInvoiceTypeCurrencies>();
            LkpInvoiceTypeCurrenciesFreeTaxAccount = new HashSet<LkpInvoiceTypeCurrencies>();
            TblAccAccountBalances = new HashSet<TblAccAccountBalances>();
            TblAccAccountCurrencyLinks = new HashSet<TblAccAccountCurrencyLinks>();
            TblAccAccountLinks = new HashSet<TblAccAccountLinks>();
            TblAccAccountPayableDetails = new HashSet<TblAccAccountPayableDetails>();
            TblAccJournalDetails = new HashSet<TblAccJournalDetails>();
            TblAstAssetActions = new HashSet<TblAstAssetActions>();
            TblAstAssetsAssetAccount = new HashSet<TblAstAssets>();
            TblAstAssetsDepreciationAccount = new HashSet<TblAstAssets>();
            TblAstAssetsTotalDepreciationAccount = new HashSet<TblAstAssets>();
            TblContractedLineCurrencies = new HashSet<TblContractedLineCurrencies>();
            TblInvoicePaymentDetails = new HashSet<TblInvoicePaymentDetails>();
            TblMembers = new HashSet<TblMembers>();
        }

        public int AccountId { get; set; }
        public string Code { get; set; }
        public int AccountSegmentId { get; set; }
        public int? ParentAccountId { get; set; }
        public string AccountNumber { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int CurrencyId { get; set; }
        public int AccountTypeId { get; set; }
        public bool? IsActive { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsParentAccount { get; set; }
        public int? ActivityId { get; set; }
        public int? SubActivityId { get; set; }

        public virtual LkpAccAccountSegments AccountSegment { get; set; }
        public virtual LkpAccAccountTypes AccountType { get; set; }
        public virtual LkpActivity Activity { get; set; }
        public virtual LkpCurrencies Currency { get; set; }
        public virtual TblAccAccounts ParentAccount { get; set; }
        public virtual LkpSubActivity SubActivity { get; set; }
        public virtual TblAccountShareSettings TblAccountShareSettings { get; set; }
        public virtual ICollection<TblAccAccounts> InverseParentAccount { get; set; }
        public virtual ICollection<LkpAccTreasuryCurrencies> LkpAccTreasuryCurrencies { get; set; }
        public virtual ICollection<LkpBankAccounts> LkpBankAccounts { get; set; }
        public virtual ICollection<LkpExpensesTypeActivities> LkpExpensesTypeActivities { get; set; }
        public virtual ICollection<LkpInvoiceTypeCurrencies> LkpInvoiceTypeCurrenciesAccount { get; set; }
        public virtual ICollection<LkpInvoiceTypeCurrencies> LkpInvoiceTypeCurrenciesFreeTaxAccount { get; set; }
        public virtual ICollection<TblAccAccountBalances> TblAccAccountBalances { get; set; }
        public virtual ICollection<TblAccAccountCurrencyLinks> TblAccAccountCurrencyLinks { get; set; }
        public virtual ICollection<TblAccAccountLinks> TblAccAccountLinks { get; set; }
        public virtual ICollection<TblAccAccountPayableDetails> TblAccAccountPayableDetails { get; set; }
        public virtual ICollection<TblAccJournalDetails> TblAccJournalDetails { get; set; }
        public virtual ICollection<TblAstAssetActions> TblAstAssetActions { get; set; }
        public virtual ICollection<TblAstAssets> TblAstAssetsAssetAccount { get; set; }
        public virtual ICollection<TblAstAssets> TblAstAssetsDepreciationAccount { get; set; }
        public virtual ICollection<TblAstAssets> TblAstAssetsTotalDepreciationAccount { get; set; }
        public virtual ICollection<TblContractedLineCurrencies> TblContractedLineCurrencies { get; set; }
        public virtual ICollection<TblInvoicePaymentDetails> TblInvoicePaymentDetails { get; set; }
        public virtual ICollection<TblMembers> TblMembers { get; set; }
    }
}

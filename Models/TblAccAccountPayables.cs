using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblAccAccountPayables
    {
        public TblAccAccountPayables()
        {
            TblAccAccountPayableDetails = new HashSet<TblAccAccountPayableDetails>();
            TblAccAccountPayableJournals = new HashSet<TblAccAccountPayableJournals>();
            TblAccountPayableSupplierInvoiceLinks = new HashSet<TblAccountPayableSupplierInvoiceLinks>();
            TblUserEvents = new HashSet<TblUserEvents>();
        }

        public int AccountPayableId { get; set; }
        public int AccountPayableTypeId { get; set; }
        public string SerialNumber { get; set; }
        public int FinancialYearId { get; set; }
        public DateTime PayableDate { get; set; }
        public string ToName { get; set; }
        public int CurrencyId { get; set; }
        public int? BankAccountId { get; set; }
        public int? TreasuryId { get; set; }
        public string DepositOrcheckOrtransferNumber { get; set; }
        public DateTime? DepositOrcheckOrtransferDate { get; set; }
        public bool IsWaitingJournalGeneration { get; set; }
        public int? WithholdingTaxId { get; set; }
        public bool IsWaitingJournalGenerationChequeSettlement { get; set; }
        public bool IsChequeSettlemenSettled { get; set; }
        public DateTime? ChequeSettlementDate { get; set; }
        public decimal? ChequeSettlementExchangeRate { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int BranchId { get; set; }
        public int? ServiceProviderId { get; set; }
        public string ChargedReason { get; set; }
        public decimal? WithholdingTaxValue { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal TotalExpense { get; set; }
        public decimal TotalJournalAmount { get; set; }
        public int? ReceiptNumberInRecord { get; set; }
        public int SerialNumberCount { get; set; }

        public virtual LkpAccAccountPayableTypes AccountPayableType { get; set; }
        public virtual LkpBankAccounts BankAccount { get; set; }
        public virtual LkpBranches Branch { get; set; }
        public virtual LkpCurrencies Currency { get; set; }
        public virtual LkpFinancialYears FinancialYear { get; set; }
        public virtual TblServiceProviders ServiceProvider { get; set; }
        public virtual LkpAccTreasuries Treasury { get; set; }
        public virtual LkpWithholdingTaxTypes WithholdingTax { get; set; }
        public virtual ICollection<TblAccAccountPayableDetails> TblAccAccountPayableDetails { get; set; }
        public virtual ICollection<TblAccAccountPayableJournals> TblAccAccountPayableJournals { get; set; }
        public virtual ICollection<TblAccountPayableSupplierInvoiceLinks> TblAccountPayableSupplierInvoiceLinks { get; set; }
        public virtual ICollection<TblUserEvents> TblUserEvents { get; set; }
    }
}

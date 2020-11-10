using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblInvoicePayments
    {
        public TblInvoicePayments()
        {
            TblInvoicePaymentDetails = new HashSet<TblInvoicePaymentDetails>();
            TblInvoicePaymentJournals = new HashSet<TblInvoicePaymentJournals>();
            TblInvoicePaymentLinks = new HashSet<TblInvoicePaymentLinks>();
            TblMembersPayments = new HashSet<TblMembersPayments>();
            TblStudentPaymentReceivables = new HashSet<TblStudentPaymentReceivables>();
            TblUserEvents = new HashSet<TblUserEvents>();
        }

        public int InvoicePaymentId { get; set; }
        public int InvoicePaymentMethodId { get; set; }
        public int BranchId { get; set; }
        public int FinancialYearId { get; set; }
        public string ReceiptNumber { get; set; }
        public int ReceiptNumberCount { get; set; }
        public int? TreasuryId { get; set; }
        public decimal? WithholdingTaxValue { get; set; }
        public int CurrencyId { get; set; }
        public decimal ExchangeRateToLocalCurrency { get; set; }
        public int? BankAccountId { get; set; }
        public string ToAccountName { get; set; }
        public string DepositOrcheckOrtransferNumber { get; set; }
        public DateTime? DepositOrcheckOrtransferDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public int? WithholdingTaxId { get; set; }
        public bool IsWaitingJournalGeneration { get; set; }
        public string ChargedReason { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsCollected { get; set; }
        public DateTime? CollectDate { get; set; }
        public decimal? CollectExchangeRate { get; set; }
        public bool IsWaitingJournalGenerationCollected { get; set; }
        public string BankFrom { get; set; }
        public decimal? BankFees { get; set; }
        public decimal TotalAmount { get; set; }
        public int? ReceiptNumberInRecord { get; set; }
        public bool? IsGenerated { get; set; }

        public virtual LkpBankAccounts BankAccount { get; set; }
        public virtual LkpCurrencies Currency { get; set; }
        public virtual LkpFinancialYears FinancialYear { get; set; }
        public virtual LkpInvoicePaymentMethods InvoicePaymentMethod { get; set; }
        public virtual LkpAccTreasuries Treasury { get; set; }
        public virtual LkpWithholdingTaxTypes WithholdingTax { get; set; }
        public virtual ICollection<TblInvoicePaymentDetails> TblInvoicePaymentDetails { get; set; }
        public virtual ICollection<TblInvoicePaymentJournals> TblInvoicePaymentJournals { get; set; }
        public virtual ICollection<TblInvoicePaymentLinks> TblInvoicePaymentLinks { get; set; }
        public virtual ICollection<TblMembersPayments> TblMembersPayments { get; set; }
        public virtual ICollection<TblStudentPaymentReceivables> TblStudentPaymentReceivables { get; set; }
        public virtual ICollection<TblUserEvents> TblUserEvents { get; set; }
    }
}

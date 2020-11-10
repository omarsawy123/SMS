using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblInvoices
    {
        public TblInvoices()
        {
            TblCreditNoteInvoiceLinksCreditNoteInvoice = new HashSet<TblCreditNoteInvoiceLinks>();
            TblCreditNoteInvoiceLinksInvoice = new HashSet<TblCreditNoteInvoiceLinks>();
            TblInvoiceDetails = new HashSet<TblInvoiceDetails>();
            TblInvoiceJournals = new HashSet<TblInvoiceJournals>();
            TblInvoicePaymentLinks = new HashSet<TblInvoicePaymentLinks>();
        }

        public int InvoiceId { get; set; }
        public int? BookingId { get; set; }
        public int ClientId { get; set; }
        public int BranchId { get; set; }
        public int InvoiceTypeId { get; set; }
        public string InvoiceHeaderName { get; set; }
        public int? FinancialYearId { get; set; }
        public string InvoiceNumber { get; set; }
        public bool IsClaim { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal? TaxPercent { get; set; }
        public bool IsFinal { get; set; }
        public bool? DoLog { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsWaitingJournalGeneration { get; set; }
        public bool IsAccountingReviewed { get; set; }
        public int? AccountingReviewerUserId { get; set; }
        public DateTime? AccountingReviewDate { get; set; }
        public string PaymentTerms { get; set; }
        public string PaymentDetails { get; set; }
        public int CurrencyId { get; set; }
        public decimal? ExchangeRate { get; set; }
        public decimal? TotalValue { get; set; }
        public int? InvoiceToId { get; set; }
        public bool IsCollect { get; set; }
        public int? ClientOrderNumber { get; set; }
        public decimal? TaxValue { get; set; }

        public virtual TblUsers AccountingReviewerUser { get; set; }
        public virtual TblBookings Booking { get; set; }
        public virtual LkpBranches Branch { get; set; }
        public virtual TblClients Client { get; set; }
        public virtual LkpCurrencies Currency { get; set; }
        public virtual LkpFinancialYears FinancialYear { get; set; }
        public virtual LkpInvoiceTo InvoiceTo { get; set; }
        public virtual LkpInvoiceTypes InvoiceType { get; set; }
        public virtual ICollection<TblCreditNoteInvoiceLinks> TblCreditNoteInvoiceLinksCreditNoteInvoice { get; set; }
        public virtual ICollection<TblCreditNoteInvoiceLinks> TblCreditNoteInvoiceLinksInvoice { get; set; }
        public virtual ICollection<TblInvoiceDetails> TblInvoiceDetails { get; set; }
        public virtual ICollection<TblInvoiceJournals> TblInvoiceJournals { get; set; }
        public virtual ICollection<TblInvoicePaymentLinks> TblInvoicePaymentLinks { get; set; }
    }
}

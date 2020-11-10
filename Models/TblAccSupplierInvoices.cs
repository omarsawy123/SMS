using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblAccSupplierInvoices
    {
        public TblAccSupplierInvoices()
        {
            TblAccSupplierInvoiceAttachments = new HashSet<TblAccSupplierInvoiceAttachments>();
            TblAccSupplierInvoiceDetails = new HashSet<TblAccSupplierInvoiceDetails>();
            TblAccSupplierInvoiceJournals = new HashSet<TblAccSupplierInvoiceJournals>();
            TblAccountPayableSupplierInvoiceLinks = new HashSet<TblAccountPayableSupplierInvoiceLinks>();
        }

        public int SupplierInvoiceId { get; set; }
        public int SerialNumber { get; set; }
        public int FinancialYearId { get; set; }
        public string Description { get; set; }
        public int ServiceProviderId { get; set; }
        public string SupplierName { get; set; }
        public bool? IsWaitingJournalGeneration { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string InvoiceSerial { get; set; }
        public DateTime IssueDate { get; set; }
        public int? BookingId { get; set; }
        public int BranchId { get; set; }
        public decimal? TaxValue { get; set; }
        public decimal ExchangeRate { get; set; }
        public int CurrencyId { get; set; }
        public bool IsFinal { get; set; }
        public bool IsAccountingReviewed { get; set; }
        public int? AccountingReviewerUserId { get; set; }
        public DateTime? AccountingReviewDate { get; set; }
        public string Reference { get; set; }
        public decimal? TotalValue { get; set; }
        public int? SupplierOrderNumber { get; set; }
        public int? ClientId { get; set; }

        public virtual TblUsers AccountingReviewerUser { get; set; }
        public virtual TblBookings Booking { get; set; }
        public virtual LkpBranches Branch { get; set; }
        public virtual TblClients Client { get; set; }
        public virtual LkpCurrencies Currency { get; set; }
        public virtual LkpFinancialYears FinancialYear { get; set; }
        public virtual TblServiceProviders ServiceProvider { get; set; }
        public virtual ICollection<TblAccSupplierInvoiceAttachments> TblAccSupplierInvoiceAttachments { get; set; }
        public virtual ICollection<TblAccSupplierInvoiceDetails> TblAccSupplierInvoiceDetails { get; set; }
        public virtual ICollection<TblAccSupplierInvoiceJournals> TblAccSupplierInvoiceJournals { get; set; }
        public virtual ICollection<TblAccountPayableSupplierInvoiceLinks> TblAccountPayableSupplierInvoiceLinks { get; set; }
    }
}

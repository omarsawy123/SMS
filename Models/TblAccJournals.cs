using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblAccJournals
    {
        public TblAccJournals()
        {
            TblAccAccountPayableJournals = new HashSet<TblAccAccountPayableJournals>();
            TblAccJournalAttachments = new HashSet<TblAccJournalAttachments>();
            TblAccJournalDetails = new HashSet<TblAccJournalDetails>();
            TblAccSupplierInvoiceJournals = new HashSet<TblAccSupplierInvoiceJournals>();
            TblAstAssetActionJournals = new HashSet<TblAstAssetActionJournals>();
            TblDebitNoteJournals = new HashSet<TblDebitNoteJournals>();
            TblInvoiceJournals = new HashSet<TblInvoiceJournals>();
            TblInvoicePaymentJournals = new HashSet<TblInvoicePaymentJournals>();
            TblTransferJournals = new HashSet<TblTransferJournals>();
        }

        public int JournalId { get; set; }
        public int Year { get; set; }
        public int MonthId { get; set; }
        public long TransactionNum { get; set; }
        public int FinancialYearId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionName { get; set; }
        public string InvoiceNumber { get; set; }
        public int CurrencyId { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool IsPosted { get; set; }
        public int? PostUserId { get; set; }
        public DateTime? PostDate { get; set; }
        public bool IsGenerated { get; set; }
        public int? JournalGenerationTypeId { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpCurrencies Currency { get; set; }
        public virtual LkpFinancialYears FinancialYear { get; set; }
        public virtual LkpAccJournalGenerationTypes JournalGenerationType { get; set; }
        public virtual LkpMonths Month { get; set; }
        public virtual ICollection<TblAccAccountPayableJournals> TblAccAccountPayableJournals { get; set; }
        public virtual ICollection<TblAccJournalAttachments> TblAccJournalAttachments { get; set; }
        public virtual ICollection<TblAccJournalDetails> TblAccJournalDetails { get; set; }
        public virtual ICollection<TblAccSupplierInvoiceJournals> TblAccSupplierInvoiceJournals { get; set; }
        public virtual ICollection<TblAstAssetActionJournals> TblAstAssetActionJournals { get; set; }
        public virtual ICollection<TblDebitNoteJournals> TblDebitNoteJournals { get; set; }
        public virtual ICollection<TblInvoiceJournals> TblInvoiceJournals { get; set; }
        public virtual ICollection<TblInvoicePaymentJournals> TblInvoicePaymentJournals { get; set; }
        public virtual ICollection<TblTransferJournals> TblTransferJournals { get; set; }
    }
}

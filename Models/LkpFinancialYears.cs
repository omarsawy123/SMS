using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpFinancialYears
    {
        public LkpFinancialYears()
        {
            TblAccAccountBalances = new HashSet<TblAccAccountBalances>();
            TblAccAccountPayables = new HashSet<TblAccAccountPayables>();
            TblAccJournals = new HashSet<TblAccJournals>();
            TblAccSupplierInvoices = new HashSet<TblAccSupplierInvoices>();
            TblAstAssetDepreciationPeriods = new HashSet<TblAstAssetDepreciationPeriods>();
            TblDebitNotes = new HashSet<TblDebitNotes>();
            TblInvoicePayments = new HashSet<TblInvoicePayments>();
            TblInvoices = new HashSet<TblInvoices>();
            TblTransfers = new HashSet<TblTransfers>();
        }

        public int FinancialYearId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsDefault { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblAccAccountBalances> TblAccAccountBalances { get; set; }
        public virtual ICollection<TblAccAccountPayables> TblAccAccountPayables { get; set; }
        public virtual ICollection<TblAccJournals> TblAccJournals { get; set; }
        public virtual ICollection<TblAccSupplierInvoices> TblAccSupplierInvoices { get; set; }
        public virtual ICollection<TblAstAssetDepreciationPeriods> TblAstAssetDepreciationPeriods { get; set; }
        public virtual ICollection<TblDebitNotes> TblDebitNotes { get; set; }
        public virtual ICollection<TblInvoicePayments> TblInvoicePayments { get; set; }
        public virtual ICollection<TblInvoices> TblInvoices { get; set; }
        public virtual ICollection<TblTransfers> TblTransfers { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpWithholdingTaxTypes
    {
        public LkpWithholdingTaxTypes()
        {
            TblAccAccountPayables = new HashSet<TblAccAccountPayables>();
            TblInvoicePayments = new HashSet<TblInvoicePayments>();
        }

        public int WithholdingTaxId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public decimal PercentValue { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblAccAccountPayables> TblAccAccountPayables { get; set; }
        public virtual ICollection<TblInvoicePayments> TblInvoicePayments { get; set; }
    }
}

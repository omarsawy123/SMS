using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpInvoiceTo
    {
        public LkpInvoiceTo()
        {
            TblInvoices = new HashSet<TblInvoices>();
        }

        public int InvoiceToId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public bool IsImport { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblInvoices> TblInvoices { get; set; }
    }
}

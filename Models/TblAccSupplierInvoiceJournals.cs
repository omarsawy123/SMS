using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblAccSupplierInvoiceJournals
    {
        public int SupplierInvoiceId { get; set; }
        public int JournalId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblAccJournals Journal { get; set; }
        public virtual TblAccSupplierInvoices SupplierInvoice { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblCreditNoteInvoiceLinks
    {
        public int CreditNoteInvoiceId { get; set; }
        public int InvoiceId { get; set; }
        public decimal CoveredAmount { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblInvoices CreditNoteInvoice { get; set; }
        public virtual TblInvoices Invoice { get; set; }
    }
}

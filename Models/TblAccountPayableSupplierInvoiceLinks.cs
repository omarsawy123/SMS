using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblAccountPayableSupplierInvoiceLinks
    {
        public int AccountPayableId { get; set; }
        public int SupplierInvoiceId { get; set; }
        public decimal PaidValue { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblAccAccountPayables AccountPayable { get; set; }
        public virtual TblAccSupplierInvoices SupplierInvoice { get; set; }
    }
}

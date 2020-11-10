using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblAccSupplierInvoiceDetails
    {
        public int SupplierInvoiceDetailId { get; set; }
        public int SupplierInvoiceId { get; set; }
        public string ItemDescription { get; set; }
        public decimal Amount { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsGenerated { get; set; }
        public decimal Quantity { get; set; }
        public int ServiceId { get; set; }

        public virtual LkpServices Service { get; set; }
        public virtual TblAccSupplierInvoices SupplierInvoice { get; set; }
    }
}

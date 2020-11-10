using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblInvoiceDetails
    {
        public int InvoiceDetailId { get; set; }
        public int InvoiceId { get; set; }
        public decimal ItemValue { get; set; }
        public int ServiceId { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsFreeTax { get; set; }

        public virtual TblInvoices Invoice { get; set; }
        public virtual LkpServices Service { get; set; }
    }
}

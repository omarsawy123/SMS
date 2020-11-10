using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpInvoicePaymentMethods
    {
        public LkpInvoicePaymentMethods()
        {
            TblInvoicePayments = new HashSet<TblInvoicePayments>();
            TblStudentPayments = new HashSet<TblStudentPayments>();
        }

        public int InvoicePaymentMethodId { get; set; }
        public string Code { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public string ResetReceivablePrefix { get; set; }
        public int ResetReceivableZeroPadding { get; set; }
        public int ResetReceivableLastSerial { get; set; }
        public bool IsDefault { get; set; }

        public virtual ICollection<TblInvoicePayments> TblInvoicePayments { get; set; }
        public virtual ICollection<TblStudentPayments> TblStudentPayments { get; set; }
    }
}

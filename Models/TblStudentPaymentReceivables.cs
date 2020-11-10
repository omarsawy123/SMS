using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblStudentPaymentReceivables
    {
        public int InvoicePaymentId { get; set; }
        public int StudentPaymentId { get; set; }
        public decimal PaidValue { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblInvoicePayments InvoicePayment { get; set; }
        public virtual TblStudentPayments StudentPayment { get; set; }
    }
}

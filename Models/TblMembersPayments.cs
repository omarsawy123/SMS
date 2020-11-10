using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblMembersPayments
    {
        public int MembersPaymentId { get; set; }
        public int ReceiptNumber { get; set; }
        public DateTime PaymentDate { get; set; }
        public int MemberId { get; set; }
        public bool IsNewMemberShip { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public decimal Amount { get; set; }
        public bool? IsRecieved { get; set; }
        public int? RecievedUserId { get; set; }
        public DateTime? RecievedDate { get; set; }
        public int? InvoicePaymentId { get; set; }
        public string AccessId { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblInvoicePayments InvoicePayment { get; set; }
        public virtual TblMembers Member { get; set; }
    }
}

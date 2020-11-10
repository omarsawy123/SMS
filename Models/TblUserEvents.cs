using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblUserEvents
    {
        public int UserEventId { get; set; }
        public int UserId { get; set; }
        public DateTime EventDate { get; set; }
        public decimal NotificationPeriod { get; set; }
        public bool IsNotificationPeriodByDay { get; set; }
        public string Description { get; set; }
        public bool IsHidden { get; set; }
        public bool IsAutoEvent { get; set; }
        public int? EventStatusId { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int? InvoicePaymentId { get; set; }
        public int? AccountPayableId { get; set; }

        public virtual TblAccAccountPayables AccountPayable { get; set; }
        public virtual LkpEventStates EventStatus { get; set; }
        public virtual TblInvoicePayments InvoicePayment { get; set; }
        public virtual TblUsers User { get; set; }
    }
}

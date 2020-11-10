using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblAccountUserDefinedSharePercentages
    {
        public int AccountUserDefinedSharePercentageId { get; set; }
        public int? InvoicePaymentDetailId { get; set; }
        public int? AccountPayableDetailId { get; set; }
        public int? JournalDetailId { get; set; }
        public int SubActivityId { get; set; }
        public bool IsPercentage { get; set; }
        public decimal Amount { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblAccAccountPayableDetails AccountPayableDetail { get; set; }
        public virtual TblInvoicePaymentDetails InvoicePaymentDetail { get; set; }
        public virtual TblAccJournalDetails JournalDetail { get; set; }
        public virtual LkpSubActivity SubActivity { get; set; }
    }
}

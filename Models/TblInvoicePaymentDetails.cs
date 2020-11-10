using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblInvoicePaymentDetails
    {
        public TblInvoicePaymentDetails()
        {
            TblAccountUserDefinedSharePercentages = new HashSet<TblAccountUserDefinedSharePercentages>();
        }

        public int InvoicePaymentDetailId { get; set; }
        public int InvoicePaymentId { get; set; }
        public int? ClientId { get; set; }
        public int? SupplierId { get; set; }
        public decimal Amount { get; set; }
        public int? AccountId { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblAccAccounts Account { get; set; }
        public virtual TblClients Client { get; set; }
        public virtual TblInvoicePayments InvoicePayment { get; set; }
        public virtual TblServiceProviders Supplier { get; set; }
        public virtual ICollection<TblAccountUserDefinedSharePercentages> TblAccountUserDefinedSharePercentages { get; set; }
    }
}

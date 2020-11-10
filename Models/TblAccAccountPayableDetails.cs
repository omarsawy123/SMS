using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblAccAccountPayableDetails
    {
        public TblAccAccountPayableDetails()
        {
            TblAccountUserDefinedSharePercentages = new HashSet<TblAccountUserDefinedSharePercentages>();
        }

        public int AccountPayableDetailId { get; set; }
        public int AccountPayableId { get; set; }
        public int? AccountId { get; set; }
        public int? ServiceProviderId { get; set; }
        public int? ClientId { get; set; }
        public string ItemDescription { get; set; }
        public decimal Amount { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int? BookingId { get; set; }
        public bool IsCost { get; set; }

        public virtual TblAccAccounts Account { get; set; }
        public virtual TblAccAccountPayables AccountPayable { get; set; }
        public virtual TblBookings Booking { get; set; }
        public virtual TblClients Client { get; set; }
        public virtual TblServiceProviders ServiceProvider { get; set; }
        public virtual ICollection<TblAccountUserDefinedSharePercentages> TblAccountUserDefinedSharePercentages { get; set; }
    }
}

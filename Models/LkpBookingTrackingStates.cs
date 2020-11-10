using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpBookingTrackingStates
    {
        public LkpBookingTrackingStates()
        {
            TblBookingTracking = new HashSet<TblBookingTracking>();
        }

        public int BookingTrackingStatusId { get; set; }
        public string Code { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int SequenceOrder { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblBookingTracking> TblBookingTracking { get; set; }
    }
}

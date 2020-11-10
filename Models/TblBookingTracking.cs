using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblBookingTracking
    {
        public int BookingTrackingId { get; set; }
        public int BookingId { get; set; }
        public int BookingTrackingStatusId { get; set; }
        public DateTime EventDate { get; set; }
        public int PortId { get; set; }
        public string Location { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblBookings Booking { get; set; }
        public virtual LkpBookingTrackingStates BookingTrackingStatus { get; set; }
        public virtual LkpPorts Port { get; set; }
    }
}

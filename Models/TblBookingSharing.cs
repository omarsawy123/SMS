using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblBookingSharing
    {
        public int BookingSharingId { get; set; }
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public bool HasWritePermission { get; set; }
        public bool HasDeletePermission { get; set; }
        public bool HasReadSalesPermission { get; set; }
        public bool HasReadCostPermission { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblBookings Booking { get; set; }
        public virtual TblUsers User { get; set; }
    }
}

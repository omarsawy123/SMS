using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblBookingTrucking
    {
        public int BookingTruckingId { get; set; }
        public int BookingId { get; set; }
        public int? TruckerId { get; set; }
        public string TruckingNumber { get; set; }
        public string Notes { get; set; }
        public string DriverName { get; set; }
        public string DriverMobile { get; set; }
        public string DriverLicenseNumber { get; set; }
        public string ContainerNumber { get; set; }
        public int? ContainerTypeId { get; set; }
        public int? ContainerSizeId { get; set; }
        public DateTime? HandOverDate { get; set; }
        public DateTime? ArrivedDate { get; set; }
        public DateTime? LeavingDate { get; set; }
        public int? ExtraDays { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }

        public virtual TblBookings Booking { get; set; }
        public virtual LkpContainerSizes ContainerSize { get; set; }
        public virtual LkpContainerTypes ContainerType { get; set; }
        public virtual TblServiceProviders Trucker { get; set; }
    }
}

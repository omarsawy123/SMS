using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpBookingStates
    {
        public LkpBookingStates()
        {
            TblBookings = new HashSet<TblBookings>();
            TblQuotes = new HashSet<TblQuotes>();
        }

        public int BookingStatusId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public bool? ShowInQuotes { get; set; }
        public bool? ShowInBooking { get; set; }
        public int SequenceOrder { get; set; }
        public bool IsDraft { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblBookings> TblBookings { get; set; }
        public virtual ICollection<TblQuotes> TblQuotes { get; set; }
    }
}

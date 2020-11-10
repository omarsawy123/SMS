using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblClientContactPersons
    {
        public TblClientContactPersons()
        {
            TblBookingsConsigneeContactPerson = new HashSet<TblBookings>();
            TblBookingsFirstNotifierContactPerson = new HashSet<TblBookings>();
            TblBookingsSecondNotifierContactPerson = new HashSet<TblBookings>();
            TblBookingsShipperContactPerson = new HashSet<TblBookings>();
        }

        public int ClientContactPersonId { get; set; }
        public int? ClientId { get; set; }
        public int? ContactPersonTypeId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string DirectPhone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblClients Client { get; set; }
        public virtual LkpContactPersonTypes ContactPersonType { get; set; }
        public virtual ICollection<TblBookings> TblBookingsConsigneeContactPerson { get; set; }
        public virtual ICollection<TblBookings> TblBookingsFirstNotifierContactPerson { get; set; }
        public virtual ICollection<TblBookings> TblBookingsSecondNotifierContactPerson { get; set; }
        public virtual ICollection<TblBookings> TblBookingsShipperContactPerson { get; set; }
    }
}

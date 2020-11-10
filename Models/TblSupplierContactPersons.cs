using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblSupplierContactPersons
    {
        public TblSupplierContactPersons()
        {
            TblBookingsFwagentPerson = new HashSet<TblBookings>();
            TblBookingsSupplierAgentContactPersons = new HashSet<TblBookings>();
        }

        public int SupplierContactPersonId { get; set; }
        public int SupplierId { get; set; }
        public string NameEn { get; set; }
        public string Telephone { get; set; }
        public bool? IsImport { get; set; }
        public int? TransportTypeId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int? ContactPersonTypeId { get; set; }
        public string DirectPhone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Remarks { get; set; }

        public virtual LkpContactPersonTypes ContactPersonType { get; set; }
        public virtual TblServiceProviders Supplier { get; set; }
        public virtual LkpTransportTypes TransportType { get; set; }
        public virtual ICollection<TblBookings> TblBookingsFwagentPerson { get; set; }
        public virtual ICollection<TblBookings> TblBookingsSupplierAgentContactPersons { get; set; }
    }
}

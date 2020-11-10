using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpTransportTypes
    {
        public LkpTransportTypes()
        {
            LkpBookingFunctions = new HashSet<LkpBookingFunctions>();
            LkpBookingTypes = new HashSet<LkpBookingTypes>();
            LkpPorts = new HashSet<LkpPorts>();
            TblPricingLists = new HashSet<TblPricingLists>();
            TblServiceProviders = new HashSet<TblServiceProviders>();
            TblSupplierContactPersons = new HashSet<TblSupplierContactPersons>();
            TblUsers = new HashSet<TblUsers>();
        }

        public int TransportTypeId { get; set; }
        public string Code { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<LkpBookingFunctions> LkpBookingFunctions { get; set; }
        public virtual ICollection<LkpBookingTypes> LkpBookingTypes { get; set; }
        public virtual ICollection<LkpPorts> LkpPorts { get; set; }
        public virtual ICollection<TblPricingLists> TblPricingLists { get; set; }
        public virtual ICollection<TblServiceProviders> TblServiceProviders { get; set; }
        public virtual ICollection<TblSupplierContactPersons> TblSupplierContactPersons { get; set; }
        public virtual ICollection<TblUsers> TblUsers { get; set; }
    }
}

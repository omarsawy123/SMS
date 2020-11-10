using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpBookingTypes
    {
        public LkpBookingTypes()
        {
            TblBookings = new HashSet<TblBookings>();
            TblQuotes = new HashSet<TblQuotes>();
            TblServicePrices = new HashSet<TblServicePrices>();
        }

        public int BookingTypeId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int LastHouseBl { get; set; }
        public bool IsImport { get; set; }
        public bool IsDefault { get; set; }
        public string HousePrefix { get; set; }
        public int? HouseZeroPadding { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public string Email { get; set; }
        public int TransportTypeId { get; set; }
        public string TeamName { get; set; }
        public int? DefaultClaimTypeId { get; set; }
        public int DefaultInvoiceTypeId { get; set; }
        public string ResponsiblePersonNameEn { get; set; }
        public string ResponsiblePersonNameAr { get; set; }
        public string FreightName { get; set; }
        public string OperationNumberCode { get; set; }
        public int OperationNumberZeroPadding { get; set; }
        public int OperationNumberStartSerial { get; set; }

        public virtual LkpInvoiceTypes DefaultClaimType { get; set; }
        public virtual LkpInvoiceTypes DefaultInvoiceType { get; set; }
        public virtual LkpTransportTypes TransportType { get; set; }
        public virtual ICollection<TblBookings> TblBookings { get; set; }
        public virtual ICollection<TblQuotes> TblQuotes { get; set; }
        public virtual ICollection<TblServicePrices> TblServicePrices { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpInvoiceTypes
    {
        public LkpInvoiceTypes()
        {
            LkpBookingTypesDefaultClaimType = new HashSet<LkpBookingTypes>();
            LkpBookingTypesDefaultInvoiceType = new HashSet<LkpBookingTypes>();
            LkpInvoiceTypeCurrencies = new HashSet<LkpInvoiceTypeCurrencies>();
            TblInvoices = new HashSet<TblInvoices>();
        }

        public int InvoiceTypeId { get; set; }
        public string Code { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public bool HasTax { get; set; }
        public bool IsClaim { get; set; }
        public bool IsDefault { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public string InvoiceTypePrefix { get; set; }
        public int InvoiceTypeZeroPadding { get; set; }
        public int InvoiceTypeLastSerial { get; set; }
        public bool? IsCreditNote { get; set; }

        public virtual ICollection<LkpBookingTypes> LkpBookingTypesDefaultClaimType { get; set; }
        public virtual ICollection<LkpBookingTypes> LkpBookingTypesDefaultInvoiceType { get; set; }
        public virtual ICollection<LkpInvoiceTypeCurrencies> LkpInvoiceTypeCurrencies { get; set; }
        public virtual ICollection<TblInvoices> TblInvoices { get; set; }
    }
}

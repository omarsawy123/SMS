using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpServices
    {
        public LkpServices()
        {
            TblAccSupplierInvoiceDetails = new HashSet<TblAccSupplierInvoiceDetails>();
            TblClientSalesTargets = new HashSet<TblClientSalesTargets>();
            TblInvoiceDetails = new HashSet<TblInvoiceDetails>();
            TblQuoteServices = new HashSet<TblQuoteServices>();
            TblServicePrices = new HashSet<TblServicePrices>();
        }

        public int ServiceId { get; set; }
        public int ServiceTypeId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public bool IsFreight { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsFreeTax { get; set; }

        public virtual LkpServiceTypes ServiceType { get; set; }
        public virtual ICollection<TblAccSupplierInvoiceDetails> TblAccSupplierInvoiceDetails { get; set; }
        public virtual ICollection<TblClientSalesTargets> TblClientSalesTargets { get; set; }
        public virtual ICollection<TblInvoiceDetails> TblInvoiceDetails { get; set; }
        public virtual ICollection<TblQuoteServices> TblQuoteServices { get; set; }
        public virtual ICollection<TblServicePrices> TblServicePrices { get; set; }
    }
}

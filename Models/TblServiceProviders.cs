using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblServiceProviders
    {
        public TblServiceProviders()
        {
            TblAccAccountBalances = new HashSet<TblAccAccountBalances>();
            TblAccAccountPayableDetails = new HashSet<TblAccAccountPayableDetails>();
            TblAccAccountPayables = new HashSet<TblAccAccountPayables>();
            TblAccJournalDetails = new HashSet<TblAccJournalDetails>();
            TblAccSupplierInvoices = new HashSet<TblAccSupplierInvoices>();
            TblBookingTrucking = new HashSet<TblBookingTrucking>();
            TblBookingsCustomClearanceVendor = new HashSet<TblBookings>();
            TblBookingsCustomsDealer = new HashSet<TblBookings>();
            TblBookingsFwagent = new HashSet<TblBookings>();
            TblBookingsSupplierAgent = new HashSet<TblBookings>();
            TblBookingsTruckContractor = new HashSet<TblBookings>();
            TblInvoicePaymentDetails = new HashSet<TblInvoicePaymentDetails>();
            TblPricingListPrices = new HashSet<TblPricingListPrices>();
            TblQuoteServices = new HashSet<TblQuoteServices>();
            TblQuotes = new HashSet<TblQuotes>();
            TblServicePrices = new HashSet<TblServicePrices>();
            TblServiceProviderAttachments = new HashSet<TblServiceProviderAttachments>();
            TblSupplierContactPersons = new HashSet<TblSupplierContactPersons>();
        }

        public int ServiceProviderId { get; set; }
        public int Code { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Email { get; set; }
        public string TaxNumber { get; set; }
        public string CommercialRegistrationNumber { get; set; }
        public bool IsCourier { get; set; }
        public bool IsClearanceVendor { get; set; }
        public bool IsClearancePerson { get; set; }
        public bool IsFwagent { get; set; }
        public bool IsLine { get; set; }
        public bool IsAgent { get; set; }
        public bool IsIata { get; set; }
        public bool IsTrucker { get; set; }
        public int? TransportTypeId { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public string LineName { get; set; }
        public string MainContactPerson { get; set; }

        public virtual LkpTransportTypes TransportType { get; set; }
        public virtual ICollection<TblAccAccountBalances> TblAccAccountBalances { get; set; }
        public virtual ICollection<TblAccAccountPayableDetails> TblAccAccountPayableDetails { get; set; }
        public virtual ICollection<TblAccAccountPayables> TblAccAccountPayables { get; set; }
        public virtual ICollection<TblAccJournalDetails> TblAccJournalDetails { get; set; }
        public virtual ICollection<TblAccSupplierInvoices> TblAccSupplierInvoices { get; set; }
        public virtual ICollection<TblBookingTrucking> TblBookingTrucking { get; set; }
        public virtual ICollection<TblBookings> TblBookingsCustomClearanceVendor { get; set; }
        public virtual ICollection<TblBookings> TblBookingsCustomsDealer { get; set; }
        public virtual ICollection<TblBookings> TblBookingsFwagent { get; set; }
        public virtual ICollection<TblBookings> TblBookingsSupplierAgent { get; set; }
        public virtual ICollection<TblBookings> TblBookingsTruckContractor { get; set; }
        public virtual ICollection<TblInvoicePaymentDetails> TblInvoicePaymentDetails { get; set; }
        public virtual ICollection<TblPricingListPrices> TblPricingListPrices { get; set; }
        public virtual ICollection<TblQuoteServices> TblQuoteServices { get; set; }
        public virtual ICollection<TblQuotes> TblQuotes { get; set; }
        public virtual ICollection<TblServicePrices> TblServicePrices { get; set; }
        public virtual ICollection<TblServiceProviderAttachments> TblServiceProviderAttachments { get; set; }
        public virtual ICollection<TblSupplierContactPersons> TblSupplierContactPersons { get; set; }
    }
}

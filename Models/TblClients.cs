using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblClients
    {
        public TblClients()
        {
            TblAccAccountBalances = new HashSet<TblAccAccountBalances>();
            TblAccAccountPayableDetails = new HashSet<TblAccAccountPayableDetails>();
            TblAccJournalDetails = new HashSet<TblAccJournalDetails>();
            TblAccSupplierInvoices = new HashSet<TblAccSupplierInvoices>();
            TblBookingsConsignee = new HashSet<TblBookings>();
            TblBookingsFirstNotifier = new HashSet<TblBookings>();
            TblBookingsSecondNotifier = new HashSet<TblBookings>();
            TblBookingsShipper = new HashSet<TblBookings>();
            TblClientContactPersons = new HashSet<TblClientContactPersons>();
            TblClientRateAgreements = new HashSet<TblClientRateAgreements>();
            TblClientSalesTargets = new HashSet<TblClientSalesTargets>();
            TblInvoicePaymentDetails = new HashSet<TblInvoicePaymentDetails>();
            TblInvoices = new HashSet<TblInvoices>();
            TblQuotes = new HashSet<TblQuotes>();
            TblServicePrices = new HashSet<TblServicePrices>();
        }

        public int ClientId { get; set; }
        public int ClientNumber { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public bool IsImport { get; set; }
        public bool IsExport { get; set; }
        public bool IsShipper { get; set; }
        public bool IsConsignee { get; set; }
        public bool IsNotifier { get; set; }
        public int? SalesRegionId { get; set; }
        public int? ParentClientId { get; set; }
        public int? GovernerateId { get; set; }
        public int CountryId { get; set; }
        public string TaxNumber { get; set; }
        public string CommercialRegistrationNumber { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsAir { get; set; }
        public bool? IsSea { get; set; }
        public int? CreditLimitCurrencyId { get; set; }
        public decimal? CreditLimit { get; set; }
        public int? CreditTerm { get; set; }
        public bool IsMyClient { get; set; }
        public int? ClientStatusId { get; set; }
        public string MainContactPerson { get; set; }

        public virtual LkpClientStatus ClientStatus { get; set; }
        public virtual LkpCountries Country { get; set; }
        public virtual LkpCurrencies CreditLimitCurrency { get; set; }
        public virtual LkpGovernerates Governerate { get; set; }
        public virtual LkpSalesRegions SalesRegion { get; set; }
        public virtual ICollection<TblAccAccountBalances> TblAccAccountBalances { get; set; }
        public virtual ICollection<TblAccAccountPayableDetails> TblAccAccountPayableDetails { get; set; }
        public virtual ICollection<TblAccJournalDetails> TblAccJournalDetails { get; set; }
        public virtual ICollection<TblAccSupplierInvoices> TblAccSupplierInvoices { get; set; }
        public virtual ICollection<TblBookings> TblBookingsConsignee { get; set; }
        public virtual ICollection<TblBookings> TblBookingsFirstNotifier { get; set; }
        public virtual ICollection<TblBookings> TblBookingsSecondNotifier { get; set; }
        public virtual ICollection<TblBookings> TblBookingsShipper { get; set; }
        public virtual ICollection<TblClientContactPersons> TblClientContactPersons { get; set; }
        public virtual ICollection<TblClientRateAgreements> TblClientRateAgreements { get; set; }
        public virtual ICollection<TblClientSalesTargets> TblClientSalesTargets { get; set; }
        public virtual ICollection<TblInvoicePaymentDetails> TblInvoicePaymentDetails { get; set; }
        public virtual ICollection<TblInvoices> TblInvoices { get; set; }
        public virtual ICollection<TblQuotes> TblQuotes { get; set; }
        public virtual ICollection<TblServicePrices> TblServicePrices { get; set; }
    }
}

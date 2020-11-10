using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpPorts
    {
        public LkpPorts()
        {
            TblBookingTracking = new HashSet<TblBookingTracking>();
            TblBookingsFinalDestinationPort = new HashSet<TblBookings>();
            TblBookingsFirstTransitPort = new HashSet<TblBookings>();
            TblBookingsPortOfDischarge = new HashSet<TblBookings>();
            TblBookingsPortOfLoad = new HashSet<TblBookings>();
            TblBookingsSecondTransitPort = new HashSet<TblBookings>();
            TblClientRateAgreementsPortOfDischarge = new HashSet<TblClientRateAgreements>();
            TblClientRateAgreementsPortOfLoad = new HashSet<TblClientRateAgreements>();
            TblClientSalesTargets = new HashSet<TblClientSalesTargets>();
            TblPricingListTransitPorts = new HashSet<TblPricingListTransitPorts>();
            TblPricingListsDestinationPort = new HashSet<TblPricingLists>();
            TblPricingListsPortOfLoad = new HashSet<TblPricingLists>();
            TblQuotesFinalDestinationPort = new HashSet<TblQuotes>();
            TblQuotesFirstTransitPort = new HashSet<TblQuotes>();
            TblQuotesPortOfDischarge = new HashSet<TblQuotes>();
            TblQuotesPortOfLoad = new HashSet<TblQuotes>();
            TblQuotesSecondTransitPort = new HashSet<TblQuotes>();
            TblServicePrices = new HashSet<TblServicePrices>();
        }

        public int PortId { get; set; }
        public int TransportTypeId { get; set; }
        public int? CountryId { get; set; }
        public string Code { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpCountries Country { get; set; }
        public virtual LkpTransportTypes TransportType { get; set; }
        public virtual ICollection<TblBookingTracking> TblBookingTracking { get; set; }
        public virtual ICollection<TblBookings> TblBookingsFinalDestinationPort { get; set; }
        public virtual ICollection<TblBookings> TblBookingsFirstTransitPort { get; set; }
        public virtual ICollection<TblBookings> TblBookingsPortOfDischarge { get; set; }
        public virtual ICollection<TblBookings> TblBookingsPortOfLoad { get; set; }
        public virtual ICollection<TblBookings> TblBookingsSecondTransitPort { get; set; }
        public virtual ICollection<TblClientRateAgreements> TblClientRateAgreementsPortOfDischarge { get; set; }
        public virtual ICollection<TblClientRateAgreements> TblClientRateAgreementsPortOfLoad { get; set; }
        public virtual ICollection<TblClientSalesTargets> TblClientSalesTargets { get; set; }
        public virtual ICollection<TblPricingListTransitPorts> TblPricingListTransitPorts { get; set; }
        public virtual ICollection<TblPricingLists> TblPricingListsDestinationPort { get; set; }
        public virtual ICollection<TblPricingLists> TblPricingListsPortOfLoad { get; set; }
        public virtual ICollection<TblQuotes> TblQuotesFinalDestinationPort { get; set; }
        public virtual ICollection<TblQuotes> TblQuotesFirstTransitPort { get; set; }
        public virtual ICollection<TblQuotes> TblQuotesPortOfDischarge { get; set; }
        public virtual ICollection<TblQuotes> TblQuotesPortOfLoad { get; set; }
        public virtual ICollection<TblQuotes> TblQuotesSecondTransitPort { get; set; }
        public virtual ICollection<TblServicePrices> TblServicePrices { get; set; }
    }
}

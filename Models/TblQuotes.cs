using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblQuotes
    {
        public TblQuotes()
        {
            TblBookings = new HashSet<TblBookings>();
            TblQuoteDetails = new HashSet<TblQuoteDetails>();
            TblQuoteServices = new HashSet<TblQuoteServices>();
        }

        public int QuoteId { get; set; }
        public int BookingTypeId { get; set; }
        public bool? HasTelexRelease { get; set; }
        public string ConsigneeTelephone { get; set; }
        public string ConsigneeFax { get; set; }
        public DateTime IssueDate { get; set; }
        public int PortOfDischargeId { get; set; }
        public int PortOfLoadId { get; set; }
        public int? FinalDestinationPortId { get; set; }
        public bool IsFdpsameAsPod { get; set; }
        public int BookingStatusId { get; set; }
        public DateTime? Eta { get; set; }
        public DateTime? Edd { get; set; }
        public int SalesUserId { get; set; }
        public int BranchId { get; set; }
        public string Description { get; set; }
        public int? DeliveryTermId { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int? FirstTransitPortId { get; set; }
        public int? SecondTransitPortId { get; set; }
        public bool? IsConsolidated { get; set; }
        public int ClientId { get; set; }
        public int? SupplierAgentId { get; set; }

        public virtual LkpBookingStates BookingStatus { get; set; }
        public virtual LkpBookingTypes BookingType { get; set; }
        public virtual LkpBranches Branch { get; set; }
        public virtual TblClients Client { get; set; }
        public virtual LkpPorts FinalDestinationPort { get; set; }
        public virtual LkpPorts FirstTransitPort { get; set; }
        public virtual LkpPorts PortOfDischarge { get; set; }
        public virtual LkpPorts PortOfLoad { get; set; }
        public virtual TblUsers SalesUser { get; set; }
        public virtual LkpPorts SecondTransitPort { get; set; }
        public virtual TblServiceProviders SupplierAgent { get; set; }
        public virtual ICollection<TblBookings> TblBookings { get; set; }
        public virtual ICollection<TblQuoteDetails> TblQuoteDetails { get; set; }
        public virtual ICollection<TblQuoteServices> TblQuoteServices { get; set; }
    }
}

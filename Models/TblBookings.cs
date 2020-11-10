using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblBookings
    {
        public TblBookings()
        {
            InverseBookingConsolidation = new HashSet<TblBookings>();
            TblAccAccountPayableDetails = new HashSet<TblAccAccountPayableDetails>();
            TblAccSupplierInvoices = new HashSet<TblAccSupplierInvoices>();
            TblBookingAttachments = new HashSet<TblBookingAttachments>();
            TblBookingDetails = new HashSet<TblBookingDetails>();
            TblBookingSharing = new HashSet<TblBookingSharing>();
            TblBookingTracking = new HashSet<TblBookingTracking>();
            TblBookingTrucking = new HashSet<TblBookingTrucking>();
            TblInvoices = new HashSet<TblInvoices>();
        }

        public int BookingId { get; set; }
        public string JobReference { get; set; }
        public string BookingRefrence { get; set; }
        public bool? HasTelexRelease { get; set; }
        public int? BookingCount { get; set; }
        public int BookingTypeId { get; set; }
        public int? QuoteId { get; set; }
        public string VoyageNumber { get; set; }
        public int? TruckContractorId { get; set; }
        public int? CustomsDealerId { get; set; }
        public int? FwagentId { get; set; }
        public string MasterBlnumber { get; set; }
        public int? HouseBlnumber { get; set; }
        public string LineAttention { get; set; }
        public string ShipperAddress { get; set; }
        public string ConsigneeAddress { get; set; }
        public bool IsNotifierSameAsConsignee { get; set; }
        public DateTime BookingIssueDate { get; set; }
        public DateTime? BolissueDate { get; set; }
        public int? NumOfOriginals { get; set; }
        public int? NumOfCopies { get; set; }
        public int PortOfDischargeId { get; set; }
        public int PortOfLoadId { get; set; }
        public int? FinalDestinationPortId { get; set; }
        public bool IsFdpsameAsPod { get; set; }
        public int BookingStatusId { get; set; }
        public DateTime? Eta { get; set; }
        public DateTime? Edd { get; set; }
        public int? ResponsibleUserId { get; set; }
        public int BranchId { get; set; }
        public string Description { get; set; }
        public int? DeliveryTermId { get; set; }
        public string Remarks { get; set; }
        public bool IsBlockingReleased { get; set; }
        public string BlockingReleaseRemarks { get; set; }
        public int? BlockingReleaseUserId { get; set; }
        public DateTime? BlockingReleaseDate { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int? BookingInvoiceUnApprovalUserId { get; set; }
        public string FirstNotifierAddress { get; set; }
        public string SecondNotifierAddress { get; set; }
        public int? BookingConsolidationId { get; set; }
        public int? FirstTransitPortId { get; set; }
        public int? SecondTransitPortId { get; set; }
        public string ChargesDueAgent1 { get; set; }
        public string ChargesDueAgent2 { get; set; }
        public string ChargesDueCarrier1 { get; set; }
        public string ChargesDueCarrier2 { get; set; }
        public string TotalPrepaid { get; set; }
        public string TotalCollect { get; set; }
        public string CurrencyConversionRates { get; set; }
        public string ChargesAtDestination { get; set; }
        public string TotalCollectCharges { get; set; }
        public string OtherCharges { get; set; }
        public string ChargesInDestinationCurrency { get; set; }
        public DateTime? CutOffDateHandOverDate { get; set; }
        public int? FwagentPersonId { get; set; }
        public int? HouseConsolidationCodeId { get; set; }
        public DateTime? PreAlertDate { get; set; }
        public string AirFirstMasterBlnumber { get; set; }
        public string AirSecondMasterBlnumber { get; set; }
        public string AirThirdMasterBlnumber { get; set; }
        public string Donumber { get; set; }
        public int? Docount { get; set; }
        public int? SupplierAgentId { get; set; }
        public string HouseBlcode { get; set; }
        public int? ShipperId { get; set; }
        public int? ShipperContactPersonId { get; set; }
        public int? ConsigneeId { get; set; }
        public int? ConsigneeContactPersonId { get; set; }
        public int? FirstNotifierId { get; set; }
        public int? FirstNotifierContactPersonId { get; set; }
        public int? SecondNotifierId { get; set; }
        public int? SecondNotifierContactPersonId { get; set; }
        public DateTime? ActualDeparture { get; set; }
        public DateTime? ActualArrival { get; set; }
        public string ShippingNotes { get; set; }
        public int? CustomClearanceVendorId { get; set; }
        public bool? CustomClearanceIsVendor { get; set; }
        public string CustomClearanceVendorAddress { get; set; }
        public string CustomClearanceVendorDurationPeriod { get; set; }
        public string CustomClearanceVendorNotes { get; set; }
        public string CustomsDealerMobile { get; set; }
        public string FwagentAddress { get; set; }
        public string VesselName { get; set; }
        public int? SupplierAgentContactPersonsId { get; set; }
        public bool IsRouting { get; set; }
        public bool IsClearance { get; set; }
        public bool IsTrucking { get; set; }
        public bool IsLocked { get; set; }
        public bool? EndorsementIsConsignee { get; set; }
        public string EndorsementToName { get; set; }
        public bool? ShowHblinEndorsementLetter { get; set; }
        public string EndorsementNumber { get; set; }
        public int? EndorsementCount { get; set; }
        public DateTime? EndorsementDate { get; set; }
        public string EndorsementSubmittedToName { get; set; }
        public bool? EndorsementDisplayShippingLine { get; set; }

        public virtual TblUsers BlockingReleaseUser { get; set; }
        public virtual TblBookings BookingConsolidation { get; set; }
        public virtual LkpBookingStates BookingStatus { get; set; }
        public virtual LkpBookingTypes BookingType { get; set; }
        public virtual LkpBranches Branch { get; set; }
        public virtual TblClients Consignee { get; set; }
        public virtual TblClientContactPersons ConsigneeContactPerson { get; set; }
        public virtual TblServiceProviders CustomClearanceVendor { get; set; }
        public virtual TblServiceProviders CustomsDealer { get; set; }
        public virtual LkpDeliveryTerms DeliveryTerm { get; set; }
        public virtual LkpPorts FinalDestinationPort { get; set; }
        public virtual TblClients FirstNotifier { get; set; }
        public virtual TblClientContactPersons FirstNotifierContactPerson { get; set; }
        public virtual LkpPorts FirstTransitPort { get; set; }
        public virtual TblServiceProviders Fwagent { get; set; }
        public virtual TblSupplierContactPersons FwagentPerson { get; set; }
        public virtual LkpHouseConsolidationCodes HouseConsolidationCode { get; set; }
        public virtual LkpPorts PortOfDischarge { get; set; }
        public virtual LkpPorts PortOfLoad { get; set; }
        public virtual TblQuotes Quote { get; set; }
        public virtual TblUsers ResponsibleUser { get; set; }
        public virtual TblClients SecondNotifier { get; set; }
        public virtual TblClientContactPersons SecondNotifierContactPerson { get; set; }
        public virtual LkpPorts SecondTransitPort { get; set; }
        public virtual TblClients Shipper { get; set; }
        public virtual TblClientContactPersons ShipperContactPerson { get; set; }
        public virtual TblServiceProviders SupplierAgent { get; set; }
        public virtual TblSupplierContactPersons SupplierAgentContactPersons { get; set; }
        public virtual TblServiceProviders TruckContractor { get; set; }
        public virtual ICollection<TblBookings> InverseBookingConsolidation { get; set; }
        public virtual ICollection<TblAccAccountPayableDetails> TblAccAccountPayableDetails { get; set; }
        public virtual ICollection<TblAccSupplierInvoices> TblAccSupplierInvoices { get; set; }
        public virtual ICollection<TblBookingAttachments> TblBookingAttachments { get; set; }
        public virtual ICollection<TblBookingDetails> TblBookingDetails { get; set; }
        public virtual ICollection<TblBookingSharing> TblBookingSharing { get; set; }
        public virtual ICollection<TblBookingTracking> TblBookingTracking { get; set; }
        public virtual ICollection<TblBookingTrucking> TblBookingTrucking { get; set; }
        public virtual ICollection<TblInvoices> TblInvoices { get; set; }
    }
}

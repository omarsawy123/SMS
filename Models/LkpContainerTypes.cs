using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpContainerTypes
    {
        public LkpContainerTypes()
        {
            TblBookingDetails = new HashSet<TblBookingDetails>();
            TblBookingTrucking = new HashSet<TblBookingTrucking>();
            TblClientRateAgreementContainers = new HashSet<TblClientRateAgreementContainers>();
            TblPricingLists = new HashSet<TblPricingLists>();
            TblQuoteDetails = new HashSet<TblQuoteDetails>();
        }

        public int ContainerTypeId { get; set; }
        public string Code { get; set; }
        public string NameEn { get; set; }
        public bool IsSealable { get; set; }
        public bool IsOutOfGage { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblBookingDetails> TblBookingDetails { get; set; }
        public virtual ICollection<TblBookingTrucking> TblBookingTrucking { get; set; }
        public virtual ICollection<TblClientRateAgreementContainers> TblClientRateAgreementContainers { get; set; }
        public virtual ICollection<TblPricingLists> TblPricingLists { get; set; }
        public virtual ICollection<TblQuoteDetails> TblQuoteDetails { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpContainerSizes
    {
        public LkpContainerSizes()
        {
            TblBookingDetails = new HashSet<TblBookingDetails>();
            TblBookingTrucking = new HashSet<TblBookingTrucking>();
            TblClientRateAgreementContainers = new HashSet<TblClientRateAgreementContainers>();
            TblPricingLists = new HashSet<TblPricingLists>();
            TblQuoteDetails = new HashSet<TblQuoteDetails>();
        }

        public int ContainerSizeId { get; set; }
        public string Code { get; set; }
        public decimal LengthInFt { get; set; }
        public decimal DefaultTareWeightInTon { get; set; }
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

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblPricingLists
    {
        public TblPricingLists()
        {
            TblPricingListPrices = new HashSet<TblPricingListPrices>();
        }

        public int PricingListId { get; set; }
        public int PortOfLoadId { get; set; }
        public int DestinationPortId { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int TransportTypeId { get; set; }
        public int? ContainerTypeId { get; set; }
        public int? ContainerSizeId { get; set; }

        public virtual LkpContainerSizes ContainerSize { get; set; }
        public virtual LkpContainerTypes ContainerType { get; set; }
        public virtual LkpPorts DestinationPort { get; set; }
        public virtual LkpPorts PortOfLoad { get; set; }
        public virtual LkpTransportTypes TransportType { get; set; }
        public virtual ICollection<TblPricingListPrices> TblPricingListPrices { get; set; }
    }
}

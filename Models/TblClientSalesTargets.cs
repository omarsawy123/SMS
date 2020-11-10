using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblClientSalesTargets
    {
        public int ClientSalesTargetId { get; set; }
        public int ClientId { get; set; }
        public int? ServiceId { get; set; }
        public int? CommodityId { get; set; }
        public int? DestinationPortId { get; set; }
        public int SalesTargetStatusId { get; set; }
        public int SalesTargetTypeId { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblClients Client { get; set; }
        public virtual LkpCommodities Commodity { get; set; }
        public virtual LkpPorts DestinationPort { get; set; }
        public virtual LkpSalesTargetStates SalesTargetStatus { get; set; }
        public virtual LkpSalesTargetTypes SalesTargetType { get; set; }
        public virtual LkpServices Service { get; set; }
    }
}

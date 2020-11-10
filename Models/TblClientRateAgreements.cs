using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblClientRateAgreements
    {
        public TblClientRateAgreements()
        {
            TblClientRateAgreementContainers = new HashSet<TblClientRateAgreementContainers>();
        }

        public int ClientRateAgreementId { get; set; }
        public int ClientId { get; set; }
        public int PortOfLoadId { get; set; }
        public int PortOfDischargeId { get; set; }
        public int? CommodityId { get; set; }
        public string ClientRanumber { get; set; }
        public bool IsActive { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblClients Client { get; set; }
        public virtual LkpCommodities Commodity { get; set; }
        public virtual LkpPorts PortOfDischarge { get; set; }
        public virtual LkpPorts PortOfLoad { get; set; }
        public virtual ICollection<TblClientRateAgreementContainers> TblClientRateAgreementContainers { get; set; }
    }
}

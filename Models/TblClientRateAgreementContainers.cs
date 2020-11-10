using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblClientRateAgreementContainers
    {
        public int ClientRateAgreementContainerId { get; set; }
        public int ClientRateAgreementId { get; set; }
        public int? ContainerSizeId { get; set; }
        public int? ContainerTypeId { get; set; }
        public decimal Price { get; set; }
        public int CurrencyId { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblClientRateAgreements ClientRateAgreement { get; set; }
        public virtual LkpContainerSizes ContainerSize { get; set; }
        public virtual LkpContainerTypes ContainerType { get; set; }
        public virtual LkpCurrencies Currency { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblAstAssetDepreciations
    {
        public int AssetDepreciationId { get; set; }
        public int AssetDepreciationPeriodId { get; set; }
        public int AssetId { get; set; }
        public decimal AssetAmount { get; set; }
        public decimal DepreciationPercentage { get; set; }
        public decimal DepreciationAmount { get; set; }
        public decimal TotalDepreciationAmountAfter { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblAstAssets Asset { get; set; }
        public virtual TblAstAssetDepreciationPeriods AssetDepreciationPeriod { get; set; }
    }
}

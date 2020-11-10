using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblAstAssetDepreciationPeriods
    {
        public TblAstAssetDepreciationPeriods()
        {
            TblAstAssetDepreciations = new HashSet<TblAstAssetDepreciations>();
        }

        public int AssetDepreciationPeriodId { get; set; }
        public int FinancialYearId { get; set; }
        public DateTime ToDate { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpFinancialYears FinancialYear { get; set; }
        public virtual ICollection<TblAstAssetDepreciations> TblAstAssetDepreciations { get; set; }
    }
}

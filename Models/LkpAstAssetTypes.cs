using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpAstAssetTypes
    {
        public LkpAstAssetTypes()
        {
            LkpAstAssetItemTypes = new HashSet<LkpAstAssetItemTypes>();
        }

        public int AssetTypeId { get; set; }
        public int AssetCategoryId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public decimal DepreciationPercentage { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpAstAssetCategories AssetCategory { get; set; }
        public virtual ICollection<LkpAstAssetItemTypes> LkpAstAssetItemTypes { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpAstAssetCategories
    {
        public LkpAstAssetCategories()
        {
            LkpAstAssetTypes = new HashSet<LkpAstAssetTypes>();
        }

        public int AssetCategoryId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int? AssetAccountId { get; set; }
        public int? DepreciationAccountId { get; set; }
        public int? TotalDepreciationAccountId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<LkpAstAssetTypes> LkpAstAssetTypes { get; set; }
    }
}

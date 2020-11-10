using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpAstAssetItemTypes
    {
        public LkpAstAssetItemTypes()
        {
            TblAstAssets = new HashSet<TblAstAssets>();
        }

        public int AssetItemTypeId { get; set; }
        public int AssetTypeId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpAstAssetTypes AssetType { get; set; }
        public virtual ICollection<TblAstAssets> TblAstAssets { get; set; }
    }
}

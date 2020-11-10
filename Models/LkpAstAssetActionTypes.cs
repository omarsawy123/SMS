using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpAstAssetActionTypes
    {
        public LkpAstAssetActionTypes()
        {
            TblAstAssetActions = new HashSet<TblAstAssetActions>();
        }

        public int AssetActionTypeId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public bool? IsTransfer { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblAstAssetActions> TblAstAssetActions { get; set; }
    }
}

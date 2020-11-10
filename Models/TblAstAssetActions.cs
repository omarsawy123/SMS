using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblAstAssetActions
    {
        public TblAstAssetActions()
        {
            TblAstAssetActionJournals = new HashSet<TblAstAssetActionJournals>();
            TblAstAssets = new HashSet<TblAstAssets>();
        }

        public int AssetActionId { get; set; }
        public int AssetActionTypeId { get; set; }
        public DateTime ActionDate { get; set; }
        public int FromAssetId { get; set; }
        public int Quantity { get; set; }
        public int? ActivityId { get; set; }
        public int? SubActivityId { get; set; }
        public int? AssetProfitAccountId { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public string ReceivableNumber { get; set; }
        public string ExclusionReason { get; set; }
        public decimal? SellingPrice { get; set; }

        public virtual LkpActivity Activity { get; set; }
        public virtual LkpAstAssetActionTypes AssetActionType { get; set; }
        public virtual TblAccAccounts AssetProfitAccount { get; set; }
        public virtual TblAstAssets FromAsset { get; set; }
        public virtual LkpSubActivity SubActivity { get; set; }
        public virtual ICollection<TblAstAssetActionJournals> TblAstAssetActionJournals { get; set; }
        public virtual ICollection<TblAstAssets> TblAstAssets { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblAstAssets
    {
        public TblAstAssets()
        {
            TblAstAssetActions = new HashSet<TblAstAssetActions>();
            TblAstAssetDepreciations = new HashSet<TblAstAssetDepreciations>();
        }

        public int AssetId { get; set; }
        public int InternalSerial { get; set; }
        public int AssetItemTypeId { get; set; }
        public string NameEn { get; set; }
        public string SupplierName { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? InServiceDate { get; set; }
        public string AssetSerialNumber { get; set; }
        public string MarkName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public decimal UnitPrice { get; set; }
        public int TotalQuantity { get; set; }
        public int CurrentQuantity { get; set; }
        public string PageNumber { get; set; }
        public string ResponsibleEmployee { get; set; }
        public string GuaranteeDetails { get; set; }
        public DateTime? EndOfGuaranteeDate { get; set; }
        public string PayableReceiptNumber { get; set; }
        public string Remarks { get; set; }
        public int ActivityId { get; set; }
        public int? SubActivityId { get; set; }
        public int AssetStatusId { get; set; }
        public int? MovedAssetActionId { get; set; }
        public int DepreciationCalculationTypeId { get; set; }
        public decimal? IntialTotalDepreciationAmount { get; set; }
        public DateTime StartDepreciationDate { get; set; }
        public int? AssetAccountId { get; set; }
        public int? DepreciationAccountId { get; set; }
        public int? TotalDepreciationAccountId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int? CsvserialNumber { get; set; }

        public virtual LkpActivity Activity { get; set; }
        public virtual TblAccAccounts AssetAccount { get; set; }
        public virtual LkpAstAssetItemTypes AssetItemType { get; set; }
        public virtual LkpAstAssetStates AssetStatus { get; set; }
        public virtual TblAccAccounts DepreciationAccount { get; set; }
        public virtual LkpAstDepreciationCalculationTypes DepreciationCalculationType { get; set; }
        public virtual TblAstAssetActions MovedAssetAction { get; set; }
        public virtual LkpSubActivity SubActivity { get; set; }
        public virtual TblAccAccounts TotalDepreciationAccount { get; set; }
        public virtual ICollection<TblAstAssetActions> TblAstAssetActions { get; set; }
        public virtual ICollection<TblAstAssetDepreciations> TblAstAssetDepreciations { get; set; }
    }
}

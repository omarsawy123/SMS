using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpSubActivity
    {
        public LkpSubActivity()
        {
            TblAccAccounts = new HashSet<TblAccAccounts>();
            TblAccountUserDefinedSharePercentages = new HashSet<TblAccountUserDefinedSharePercentages>();
            TblAstAssetActions = new HashSet<TblAstAssetActions>();
            TblAstAssets = new HashSet<TblAstAssets>();
            TblSubActivitiesSharePercentageSettings = new HashSet<TblSubActivitiesSharePercentageSettings>();
        }

        public int SubActivityId { get; set; }
        public int ActivityId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsMajor { get; set; }
        public bool? NotEncludedInSharePercentage { get; set; }
        public int? SortOrder { get; set; }
        public decimal Factor { get; set; }

        public virtual LkpActivity Activity { get; set; }
        public virtual ICollection<TblAccAccounts> TblAccAccounts { get; set; }
        public virtual ICollection<TblAccountUserDefinedSharePercentages> TblAccountUserDefinedSharePercentages { get; set; }
        public virtual ICollection<TblAstAssetActions> TblAstAssetActions { get; set; }
        public virtual ICollection<TblAstAssets> TblAstAssets { get; set; }
        public virtual ICollection<TblSubActivitiesSharePercentageSettings> TblSubActivitiesSharePercentageSettings { get; set; }
    }
}

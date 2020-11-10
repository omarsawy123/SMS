using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpActivity
    {
        public LkpActivity()
        {
            LkpExpensesTypeActivities = new HashSet<LkpExpensesTypeActivities>();
            LkpSubActivity = new HashSet<LkpSubActivity>();
            TblAccAccounts = new HashSet<TblAccAccounts>();
            TblAstAssetActions = new HashSet<TblAstAssetActions>();
            TblAstAssets = new HashSet<TblAstAssets>();
        }

        public int ActivityId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsLoadedOnGeneralReserve { get; set; }

        public virtual ICollection<LkpExpensesTypeActivities> LkpExpensesTypeActivities { get; set; }
        public virtual ICollection<LkpSubActivity> LkpSubActivity { get; set; }
        public virtual ICollection<TblAccAccounts> TblAccAccounts { get; set; }
        public virtual ICollection<TblAstAssetActions> TblAstAssetActions { get; set; }
        public virtual ICollection<TblAstAssets> TblAstAssets { get; set; }
    }
}

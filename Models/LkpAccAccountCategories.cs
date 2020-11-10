using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpAccAccountCategories
    {
        public LkpAccAccountCategories()
        {
            LkpAccAccountTypes = new HashSet<LkpAccAccountTypes>();
        }

        public int AccountCategoryId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int? DisplayOrder { get; set; }
        public int AccountPositionTypeId { get; set; }
        public string TotalTitleAr { get; set; }
        public string TotalTitleEn { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsCurrentAssets { get; set; }
        public bool IsLongTermAssets { get; set; }
        public bool IsCurrentLiabilities { get; set; }
        public int? TshapeDisplayOrder { get; set; }

        public virtual ICollection<LkpAccAccountTypes> LkpAccAccountTypes { get; set; }
    }
}

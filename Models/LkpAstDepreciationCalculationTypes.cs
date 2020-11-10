using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpAstDepreciationCalculationTypes
    {
        public LkpAstDepreciationCalculationTypes()
        {
            TblAstAssets = new HashSet<TblAstAssets>();
        }

        public int DepreciationCalculationTypeId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public bool IsDefault { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblAstAssets> TblAstAssets { get; set; }
    }
}

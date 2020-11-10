using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpUnitTypes
    {
        public LkpUnitTypes()
        {
            LkpUnits = new HashSet<LkpUnits>();
        }

        public int UnitTypeId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<LkpUnits> LkpUnits { get; set; }
    }
}

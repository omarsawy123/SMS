using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpAdtSubModules
    {
        public LkpAdtSubModules()
        {
            LkpAdtFields = new HashSet<LkpAdtFields>();
        }

        public int SubModuleId { get; set; }
        public int ModuleId { get; set; }
        public string Code { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpAdtModules Module { get; set; }
        public virtual ICollection<LkpAdtFields> LkpAdtFields { get; set; }
    }
}

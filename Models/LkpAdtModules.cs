using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpAdtModules
    {
        public LkpAdtModules()
        {
            LkpAdtSubModules = new HashSet<LkpAdtSubModules>();
        }

        public int ModuleId { get; set; }
        public int SectionId { get; set; }
        public string Code { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<LkpAdtSubModules> LkpAdtSubModules { get; set; }
    }
}

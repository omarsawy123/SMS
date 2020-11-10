using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpAdtDepartments
    {
        public LkpAdtDepartments()
        {
            LkpAdtSections = new HashSet<LkpAdtSections>();
        }

        public int DepartmentId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string Code { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<LkpAdtSections> LkpAdtSections { get; set; }
    }
}

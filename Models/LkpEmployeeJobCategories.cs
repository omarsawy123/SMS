using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpEmployeeJobCategories
    {
        public LkpEmployeeJobCategories()
        {
            LkpEmployeeJobs = new HashSet<LkpEmployeeJobs>();
        }

        public int EmployeeJobCategoryId { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public string NameEn { get; set; }
        public bool IsCurrent { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<LkpEmployeeJobs> LkpEmployeeJobs { get; set; }
    }
}

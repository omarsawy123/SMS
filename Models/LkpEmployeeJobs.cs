using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpEmployeeJobs
    {
        public LkpEmployeeJobs()
        {
            TblEmployeeTeachingSubjects = new HashSet<TblEmployeeTeachingSubjects>();
            TblEmployees = new HashSet<TblEmployees>();
        }

        public int EmployeeJobId { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public string NameEn { get; set; }
        public int EmployeeJobCategoryId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public string IntegrationId { get; set; }
        public int? DisplayOrder { get; set; }

        public virtual LkpEmployeeJobCategories EmployeeJobCategory { get; set; }
        public virtual ICollection<TblEmployeeTeachingSubjects> TblEmployeeTeachingSubjects { get; set; }
        public virtual ICollection<TblEmployees> TblEmployees { get; set; }
    }
}

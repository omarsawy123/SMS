using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpHrstages
    {
        public LkpHrstages()
        {
            TblEmployeeTeachingSubjects = new HashSet<TblEmployeeTeachingSubjects>();
        }

        public int HrstageId { get; set; }
        public string Code { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public string SecretaryNameAr { get; set; }
        public string SecretaryNameFr { get; set; }
        public string IntegrationId { get; set; }
        public int? StudyOrder { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblEmployeeTeachingSubjects> TblEmployeeTeachingSubjects { get; set; }
    }
}

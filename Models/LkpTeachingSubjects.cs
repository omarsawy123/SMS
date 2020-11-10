using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpTeachingSubjects
    {
        public LkpTeachingSubjects()
        {
            TblEmployeeTeachingSubjects = new HashSet<TblEmployeeTeachingSubjects>();
        }

        public int TeachingSubjectId { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public string NameEn { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int? IntegrationId { get; set; }

        public virtual ICollection<TblEmployeeTeachingSubjects> TblEmployeeTeachingSubjects { get; set; }
    }
}

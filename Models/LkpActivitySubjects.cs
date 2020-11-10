using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpActivitySubjects
    {
        public LkpActivitySubjects()
        {
            TblStudentSubjects = new HashSet<TblStudentSubjects>();
        }

        public int ActivitySubjectId { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public string Grades { get; set; }
        public int? DisplayOrder { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblStudentSubjects> TblStudentSubjects { get; set; }
    }
}

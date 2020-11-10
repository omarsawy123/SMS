using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpStudentStates
    {
        public LkpStudentStates()
        {
            TblStudentAcademicYears = new HashSet<TblStudentAcademicYears>();
        }

        public int StudentStatusId { get; set; }
        public string Code { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public string PluralNameAr { get; set; }

        public virtual ICollection<TblStudentAcademicYears> TblStudentAcademicYears { get; set; }
    }
}

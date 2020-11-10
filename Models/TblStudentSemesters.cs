using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblStudentSemesters
    {
        public TblStudentSemesters()
        {
            TblStudentExams = new HashSet<TblStudentExams>();
            TblStudentSubjects = new HashSet<TblStudentSubjects>();
        }

        public int StudentSemesterId { get; set; }
        public int StudentAcademicYearId { get; set; }
        public int SemesterId { get; set; }
        public int? SecretNumber { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpSemesters Semester { get; set; }
        public virtual TblStudentAcademicYears StudentAcademicYear { get; set; }
        public virtual ICollection<TblStudentExams> TblStudentExams { get; set; }
        public virtual ICollection<TblStudentSubjects> TblStudentSubjects { get; set; }
    }
}

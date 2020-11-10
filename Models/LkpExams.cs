using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpExams
    {
        public LkpExams()
        {
            LkpAcademicYearExams = new HashSet<LkpAcademicYearExams>();
            TblStudentExams = new HashSet<TblStudentExams>();
        }

        public int ExamId { get; set; }
        public int GradeId { get; set; }
        public int SemesterId { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public string DisplayNameAr { get; set; }
        public string DisplayNameFr { get; set; }
        public int? DisplayOrder { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsCurrent { get; set; }

        public virtual LkpGrades Grade { get; set; }
        public virtual LkpSemesters Semester { get; set; }
        public virtual ICollection<LkpAcademicYearExams> LkpAcademicYearExams { get; set; }
        public virtual ICollection<TblStudentExams> TblStudentExams { get; set; }
    }
}

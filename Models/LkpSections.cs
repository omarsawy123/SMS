using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpSections
    {
        public LkpSections()
        {
            TblSemesterSubjectSettings = new HashSet<TblSemesterSubjectSettings>();
            TblStudentAcademicYears = new HashSet<TblStudentAcademicYears>();
        }

        public int SectionId { get; set; }
        public string Code { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public int GradeId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public string IntegrationId { get; set; }

        public virtual LkpGrades Grade { get; set; }
        public virtual ICollection<TblSemesterSubjectSettings> TblSemesterSubjectSettings { get; set; }
        public virtual ICollection<TblStudentAcademicYears> TblStudentAcademicYears { get; set; }
    }
}

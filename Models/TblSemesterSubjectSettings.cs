using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblSemesterSubjectSettings
    {
        public int SemesterSubjectSettingId { get; set; }
        public int? ClassId { get; set; }
        public int SubjectId { get; set; }
        public int? SectionId { get; set; }
        public int? SemesterId { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int GradeId { get; set; }

        public virtual LkpClasses Class { get; set; }
        public virtual LkpGrades Grade { get; set; }
        public virtual LkpSections Section { get; set; }
        public virtual LkpSemesters Semester { get; set; }
        public virtual LkpSubjects Subject { get; set; }
    }
}

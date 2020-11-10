using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblStudentSubjects
    {
        public int StudentSubjectId { get; set; }
        public int StudentSemesterId { get; set; }
        public int SubjectId { get; set; }
        public decimal? WrittenDegree { get; set; }
        public decimal? BehaviorDegree { get; set; }
        public decimal? OralDegree { get; set; }
        public decimal? ActivityDegree { get; set; }
        public decimal? PracticalDegree { get; set; }
        public bool IsAbsent { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int? ActivitySubjectId { get; set; }
        public bool? IsAbsentPractical { get; set; }
        public decimal? AttendanceDegree { get; set; }

        public virtual LkpActivitySubjects ActivitySubject { get; set; }
        public virtual TblStudentSemesters StudentSemester { get; set; }
        public virtual LkpSubjects Subject { get; set; }
    }
}

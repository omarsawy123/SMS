using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpSubjects
    {
        public LkpSubjects()
        {
            InverseGroupSubject = new HashSet<LkpSubjects>();
            TblSemesterSubjectSettings = new HashSet<TblSemesterSubjectSettings>();
            TblStudentSubjects = new HashSet<TblStudentSubjects>();
            TblUserSubjects = new HashSet<TblUserSubjects>();
        }

        public int SubjectId { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public string DisplayNameAr { get; set; }
        public string DisplayNameFr { get; set; }
        public int? DisplayOrder { get; set; }
        public int GradeId { get; set; }
        public decimal MaxMonthExam { get; set; }
        public decimal MinMonthExam { get; set; }
        public decimal MaxTermExam { get; set; }
        public decimal MinTermExam { get; set; }
        public decimal MaxTotalGrade { get; set; }
        public decimal MinTotalGrade { get; set; }
        public bool IsOptional { get; set; }
        public bool IsActivity { get; set; }
        public bool IsEndedSubject { get; set; }
        public int? EndedSubjectGroupId { get; set; }
        public bool HasPractical { get; set; }
        public decimal MaxPracticalGrade { get; set; }
        public decimal MinPracticalGrade { get; set; }
        public bool HasParticipation { get; set; }
        public decimal SemesterBehaviorGrade { get; set; }
        public decimal SemesterOralGrade { get; set; }
        public decimal SemesterActivityGrade { get; set; }
        public bool IsHighLevel { get; set; }
        public bool IsPassSubject { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public bool ShowParentAlert { get; set; }
        public decimal MinFinalExam { get; set; }
        public int MaxTermWorkYear { get; set; }
        public int MinTermWorkYear { get; set; }
        public bool? EnterDegreeByName { get; set; }
        public int? GroupSubjectId { get; set; }
        public bool? IsGroupSubject { get; set; }
        public bool? IsLanguageSubject { get; set; }
        public bool? IsSport { get; set; }
        public decimal? SemesterAttendanceGrade { get; set; }
        public decimal MinTermWritten { get; set; }
        public bool? IsActivitySubjectOutOfTotal { get; set; }
        public bool ShowInCertificates { get; set; }

        public virtual LkpEndedSubjectGroups EndedSubjectGroup { get; set; }
        public virtual LkpGrades Grade { get; set; }
        public virtual LkpSubjects GroupSubject { get; set; }
        public virtual ICollection<LkpSubjects> InverseGroupSubject { get; set; }
        public virtual ICollection<TblSemesterSubjectSettings> TblSemesterSubjectSettings { get; set; }
        public virtual ICollection<TblStudentSubjects> TblStudentSubjects { get; set; }
        public virtual ICollection<TblUserSubjects> TblUserSubjects { get; set; }
    }
}

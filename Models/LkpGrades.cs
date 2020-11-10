using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpGrades
    {
        public LkpGrades()
        {
            LkpClasses = new HashSet<LkpClasses>();
            LkpExams = new HashSet<LkpExams>();
            LkpSections = new HashSet<LkpSections>();
            LkpSubjects = new HashSet<LkpSubjects>();
            TblExpenses = new HashSet<TblExpenses>();
            TblSemesterAbsencePeriods = new HashSet<TblSemesterAbsencePeriods>();
            TblSemesterSubjectSettings = new HashSet<TblSemesterSubjectSettings>();
            TblStudentAcademicYears = new HashSet<TblStudentAcademicYears>();
            TblUserAbsenceResonsibleGrades = new HashSet<TblUserAbsenceResonsibleGrades>();
        }

        public int GradeId { get; set; }
        public int StageId { get; set; }
        public string Code { get; set; }
        public string CodeNumber { get; set; }
        public string CodeSuffix { get; set; }
        public string StageName { get; set; }
        public bool IsGeneralEvaluationOnly { get; set; }
        public bool IsEnterTermDegreesByNames { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public string DisplayNameAr { get; set; }
        public string DisplayNameFr { get; set; }
        public int StudyOrder { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public string IntegrationId { get; set; }
        public bool? IsPassAnyWay { get; set; }
        public bool? CanSelectHighLevelOnly { get; set; }
        public bool? FixedSecretNumberForAcademicYear { get; set; }
        public bool? IsMinistryExams { get; set; }
        public bool? IgnoreAchievementInTotal { get; set; }
        public string DisplayShortNameAr { get; set; }
        public string DisplayGradeNumberAr { get; set; }
        public bool NoMidTermExam { get; set; }

        public virtual LkpStages Stage { get; set; }
        public virtual LkpGradesParentNotifications LkpGradesParentNotifications { get; set; }
        public virtual ICollection<LkpClasses> LkpClasses { get; set; }
        public virtual ICollection<LkpExams> LkpExams { get; set; }
        public virtual ICollection<LkpSections> LkpSections { get; set; }
        public virtual ICollection<LkpSubjects> LkpSubjects { get; set; }
        public virtual ICollection<TblExpenses> TblExpenses { get; set; }
        public virtual ICollection<TblSemesterAbsencePeriods> TblSemesterAbsencePeriods { get; set; }
        public virtual ICollection<TblSemesterSubjectSettings> TblSemesterSubjectSettings { get; set; }
        public virtual ICollection<TblStudentAcademicYears> TblStudentAcademicYears { get; set; }
        public virtual ICollection<TblUserAbsenceResonsibleGrades> TblUserAbsenceResonsibleGrades { get; set; }
    }
}

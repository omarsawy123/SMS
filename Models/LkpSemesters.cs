using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpSemesters
    {
        public LkpSemesters()
        {
            LkpExams = new HashSet<LkpExams>();
            LkpReportsHeaderSemesters = new HashSet<LkpReportsHeaderSemesters>();
            TblSemesterAbsencePeriods = new HashSet<TblSemesterAbsencePeriods>();
            TblSemesterSubjectSettings = new HashSet<TblSemesterSubjectSettings>();
            TblStudentSemesters = new HashSet<TblStudentSemesters>();
        }

        public int SemesterId { get; set; }
        public string Code { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public string DisplayNameAr { get; set; }
        public string DisplayNameFr { get; set; }
        public bool IsCurrent { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public string NameArInMinistryReports { get; set; }

        public virtual ICollection<LkpExams> LkpExams { get; set; }
        public virtual ICollection<LkpReportsHeaderSemesters> LkpReportsHeaderSemesters { get; set; }
        public virtual ICollection<TblSemesterAbsencePeriods> TblSemesterAbsencePeriods { get; set; }
        public virtual ICollection<TblSemesterSubjectSettings> TblSemesterSubjectSettings { get; set; }
        public virtual ICollection<TblStudentSemesters> TblStudentSemesters { get; set; }
    }
}

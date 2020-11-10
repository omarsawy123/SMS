using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblSemesterAbsencePeriods
    {
        public int SemesterAbsencePeriodId { get; set; }
        public int GradeId { get; set; }
        public int AcademicYearId { get; set; }
        public int SemesterId { get; set; }
        public int? AttendanceDaysPerSemester { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpAcademicYears AcademicYear { get; set; }
        public virtual LkpGrades Grade { get; set; }
        public virtual LkpSemesters Semester { get; set; }
    }
}

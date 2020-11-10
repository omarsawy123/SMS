using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblStudentAbsences
    {
        public int StudentAbsentId { get; set; }
        public int StudentId { get; set; }
        public string Notes { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int AcademicYearId { get; set; }
        public DateTime SchoolDayDate { get; set; }
        public bool IsAbsent { get; set; }
        public int? AbsentReasonId { get; set; }

        public virtual LkpAbsenceReasons AbsentReason { get; set; }
        public virtual LkpAcademicYears AcademicYear { get; set; }
        public virtual TblStudents Student { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpAcademicYearExams
    {
        public int AcademicYearExamId { get; set; }
        public int ExamId { get; set; }
        public int AcademicYearId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpAcademicYears AcademicYear { get; set; }
        public virtual LkpExams Exam { get; set; }
    }
}

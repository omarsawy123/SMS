using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblStudentExams
    {
        public TblStudentExams()
        {
            TblStudentDegrees = new HashSet<TblStudentDegrees>();
        }

        public int StudentExamId { get; set; }
        public int StudentSemesterId { get; set; }
        public int ExamId { get; set; }
        public int? AbsenceDays { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpExams Exam { get; set; }
        public virtual TblStudentSemesters StudentSemester { get; set; }
        public virtual ICollection<TblStudentDegrees> TblStudentDegrees { get; set; }
    }
}

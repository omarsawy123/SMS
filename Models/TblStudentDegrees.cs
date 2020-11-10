using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblStudentDegrees
    {
        public int StudentDegreeId { get; set; }
        public int SubjectId { get; set; }
        public int StudentExamId { get; set; }
        public decimal? WrittenDegree { get; set; }
        public bool IsAbsent { get; set; }
        public decimal? TotalDegree { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsTotalAbsent { get; set; }
        public decimal? ActivityOralDegrees { get; set; }
        public decimal? ActivityIndividualDegrees { get; set; }
        public decimal? ActivityGroupDegrees { get; set; }
        public decimal? ActivtyGroup2Degrees { get; set; }
        public int? ColorDegreeId { get; set; }

        public virtual LkpColorDegrees ColorDegree { get; set; }
        public virtual TblStudentExams StudentExam { get; set; }
    }
}

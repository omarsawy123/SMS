using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblUserAbsenceResonsibleGrades
    {
        public int UserId { get; set; }
        public int GradeId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int UserAbsenceResonsibleGradeId { get; set; }

        public virtual LkpGrades Grade { get; set; }
        public virtual TblUsers User { get; set; }
    }
}

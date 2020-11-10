using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblEmployeeTeachingSubjects
    {
        public int EmployeeTeachingSubjectId { get; set; }
        public int EmployeeId { get; set; }
        public int? TeachingSubjectId { get; set; }
        public int? HrstageId { get; set; }
        public int? EmployeeJobId { get; set; }
        public int? NumberOfLectures { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblEmployees Employee { get; set; }
        public virtual LkpEmployeeJobs EmployeeJob { get; set; }
        public virtual LkpHrstages Hrstage { get; set; }
        public virtual LkpTeachingSubjects TeachingSubject { get; set; }
    }
}

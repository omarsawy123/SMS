using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpAreas
    {
        public LkpAreas()
        {
            TblEmployees = new HashSet<TblEmployees>();
            TblStudentWaitingLists = new HashSet<TblStudentWaitingLists>();
            TblStudents = new HashSet<TblStudents>();
        }

        public int AreaId { get; set; }
        public string NameFr { get; set; }
        public string NameAr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int? GovernerateId { get; set; }

        public virtual LkpGovernerates Governerate { get; set; }
        public virtual ICollection<TblEmployees> TblEmployees { get; set; }
        public virtual ICollection<TblStudentWaitingLists> TblStudentWaitingLists { get; set; }
        public virtual ICollection<TblStudents> TblStudents { get; set; }
    }
}

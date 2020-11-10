using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpQualifications
    {
        public LkpQualifications()
        {
            TblStudentWaitingListsFatherQualification = new HashSet<TblStudentWaitingLists>();
            TblStudentWaitingListsMotherQualification = new HashSet<TblStudentWaitingLists>();
            TblStudentsFatherQualification = new HashSet<TblStudents>();
            TblStudentsMotherQualification = new HashSet<TblStudents>();
        }

        public int QualificationId { get; set; }
        public string NameFr { get; set; }
        public string NameAr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblStudentWaitingLists> TblStudentWaitingListsFatherQualification { get; set; }
        public virtual ICollection<TblStudentWaitingLists> TblStudentWaitingListsMotherQualification { get; set; }
        public virtual ICollection<TblStudents> TblStudentsFatherQualification { get; set; }
        public virtual ICollection<TblStudents> TblStudentsMotherQualification { get; set; }
    }
}

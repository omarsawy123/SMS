using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpPaymentStates
    {
        public LkpPaymentStates()
        {
            TblStudentAcademicYearsFirstPaymentStatus = new HashSet<TblStudentAcademicYears>();
            TblStudentAcademicYearsSecondPaymentStatus = new HashSet<TblStudentAcademicYears>();
            TblStudentWaitingLists = new HashSet<TblStudentWaitingLists>();
        }

        public int PaymentStatusId { get; set; }
        public string Code { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string NameFr { get; set; }
        public bool? IsDefault { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblStudentAcademicYears> TblStudentAcademicYearsFirstPaymentStatus { get; set; }
        public virtual ICollection<TblStudentAcademicYears> TblStudentAcademicYearsSecondPaymentStatus { get; set; }
        public virtual ICollection<TblStudentWaitingLists> TblStudentWaitingLists { get; set; }
    }
}

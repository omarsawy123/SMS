using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpPaymentPortionTypes
    {
        public LkpPaymentPortionTypes()
        {
            TblExpenses = new HashSet<TblExpenses>();
            TblStudentAcademicYears = new HashSet<TblStudentAcademicYears>();
            TblStudentPayments = new HashSet<TblStudentPayments>();
        }

        public int PaymentPortionTypeId { get; set; }
        public string NameFr { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public bool IsCurrent { get; set; }
        public int DisplayOrder { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblExpenses> TblExpenses { get; set; }
        public virtual ICollection<TblStudentAcademicYears> TblStudentAcademicYears { get; set; }
        public virtual ICollection<TblStudentPayments> TblStudentPayments { get; set; }
    }
}

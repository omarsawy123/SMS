using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpPaymentDiscountTypes
    {
        public LkpPaymentDiscountTypes()
        {
            TblStudentAcademicYears = new HashSet<TblStudentAcademicYears>();
        }

        public int PaymentDiscountTypeId { get; set; }
        public string NameFr { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblStudentAcademicYears> TblStudentAcademicYears { get; set; }
    }
}

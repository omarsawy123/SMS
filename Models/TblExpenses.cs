using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblExpenses
    {
        public int ExpenseId { get; set; }
        public int AcademicYearId { get; set; }
        public int GradeId { get; set; }
        public int ExpenseTypeId { get; set; }
        public decimal Amount { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int? PaymentPortionTypeId { get; set; }

        public virtual LkpAcademicYears AcademicYear { get; set; }
        public virtual LkpExpenseTypes ExpenseType { get; set; }
        public virtual LkpGrades Grade { get; set; }
        public virtual LkpPaymentPortionTypes PaymentPortionType { get; set; }
    }
}

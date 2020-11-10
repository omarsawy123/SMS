using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpExpenseTypes
    {
        public LkpExpenseTypes()
        {
            LkpExpensesTypeActivities = new HashSet<LkpExpensesTypeActivities>();
            TblExpenses = new HashSet<TblExpenses>();
        }

        public int ExpenseTypeId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPayroll { get; set; }
        public string NameFr { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsEducationExpense { get; set; }
        public bool IsOtherExpense { get; set; }
        public bool AllowDiscount { get; set; }
        public int? PayOrder { get; set; }

        public virtual ICollection<LkpExpensesTypeActivities> LkpExpensesTypeActivities { get; set; }
        public virtual ICollection<TblExpenses> TblExpenses { get; set; }
    }
}

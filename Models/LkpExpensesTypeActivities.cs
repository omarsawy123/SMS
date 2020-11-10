using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpExpensesTypeActivities
    {
        public int ExpensesTypeActivityId { get; set; }
        public int ExpensesAccountId { get; set; }
        public int ActivityId { get; set; }
        public int ExpenseTypeId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpActivity Activity { get; set; }
        public virtual LkpExpenseTypes ExpenseType { get; set; }
        public virtual TblAccAccounts ExpensesAccount { get; set; }
    }
}

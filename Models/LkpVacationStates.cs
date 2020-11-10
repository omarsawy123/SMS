using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpVacationStates
    {
        public LkpVacationStates()
        {
            TblEmployeeVacations = new HashSet<TblEmployeeVacations>();
        }

        public int VacationStatusId { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public string NameEn { get; set; }
        public bool IsCurrent { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblEmployeeVacations> TblEmployeeVacations { get; set; }
    }
}

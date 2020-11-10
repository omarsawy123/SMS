using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblEmployeeVacations
    {
        public int EmployeeVacationId { get; set; }
        public int EmployeeId { get; set; }
        public int VacationTypeId { get; set; }
        public DateTime VacationDateFrom { get; set; }
        public DateTime VacationDateTo { get; set; }
        public int VacationStatusId { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblEmployees Employee { get; set; }
        public virtual LkpVacationStates VacationStatus { get; set; }
        public virtual LkpVacationTypes VacationType { get; set; }
    }
}

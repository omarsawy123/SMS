using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpDepartments
    {
        public LkpDepartments()
        {
            TblEmployees = new HashSet<TblEmployees>();
            TblUsers = new HashSet<TblUsers>();
        }

        public int DepartmentId { get; set; }
        public string NameFr { get; set; }
        public string NameAr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblEmployees> TblEmployees { get; set; }
        public virtual ICollection<TblUsers> TblUsers { get; set; }
    }
}

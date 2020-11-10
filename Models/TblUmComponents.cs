using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblUmComponents
    {
        public TblUmComponents()
        {
            TblRoleComponents = new HashSet<TblRoleComponents>();
            TblUmModules = new HashSet<TblUmModules>();
        }

        public int ComponentId { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public int SystemId { get; set; }
        public int? OrderBy { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblUmSystems System { get; set; }
        public virtual ICollection<TblRoleComponents> TblRoleComponents { get; set; }
        public virtual ICollection<TblUmModules> TblUmModules { get; set; }
    }
}

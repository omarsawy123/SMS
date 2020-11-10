using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblUmModules
    {
        public TblUmModules()
        {
            TblRoleModules = new HashSet<TblRoleModules>();
            TblUmServices = new HashSet<TblUmServices>();
        }

        public int ModuleId { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public int ComponentId { get; set; }
        public string StartupUrl { get; set; }
        public int? OrderBy { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblUmComponents Component { get; set; }
        public virtual ICollection<TblRoleModules> TblRoleModules { get; set; }
        public virtual ICollection<TblUmServices> TblUmServices { get; set; }
    }
}

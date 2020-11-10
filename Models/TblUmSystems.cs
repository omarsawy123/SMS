using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblUmSystems
    {
        public TblUmSystems()
        {
            TblRoleSystems = new HashSet<TblRoleSystems>();
            TblUmComponents = new HashSet<TblUmComponents>();
        }

        public int SystemId { get; set; }
        public string Name { get; set; }
        public string NameFr { get; set; }
        public string NameAr { get; set; }
        public int? OrderBy { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblRoleSystems> TblRoleSystems { get; set; }
        public virtual ICollection<TblUmComponents> TblUmComponents { get; set; }
    }
}

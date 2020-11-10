using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpPermissions
    {
        public LkpPermissions()
        {
            TblRoleComponents = new HashSet<TblRoleComponents>();
            TblRoleModules = new HashSet<TblRoleModules>();
            TblRoleServices = new HashSet<TblRoleServices>();
            TblRoleSystems = new HashSet<TblRoleSystems>();
        }

        public int PermissionId { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }
        public int Value { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblRoleComponents> TblRoleComponents { get; set; }
        public virtual ICollection<TblRoleModules> TblRoleModules { get; set; }
        public virtual ICollection<TblRoleServices> TblRoleServices { get; set; }
        public virtual ICollection<TblRoleSystems> TblRoleSystems { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblRoles
    {
        public TblRoles()
        {
            TblRoleComponents = new HashSet<TblRoleComponents>();
            TblRoleModules = new HashSet<TblRoleModules>();
            TblRoleServices = new HashSet<TblRoleServices>();
            TblRoleSystems = new HashSet<TblRoleSystems>();
            TblUserRoles = new HashSet<TblUserRoles>();
        }

        public int RoleId { get; set; }
        public string Name { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblRoleComponents> TblRoleComponents { get; set; }
        public virtual ICollection<TblRoleModules> TblRoleModules { get; set; }
        public virtual ICollection<TblRoleServices> TblRoleServices { get; set; }
        public virtual ICollection<TblRoleSystems> TblRoleSystems { get; set; }
        public virtual ICollection<TblUserRoles> TblUserRoles { get; set; }
    }
}

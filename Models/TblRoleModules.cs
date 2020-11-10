using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblRoleModules
    {
        public int RoleModuleId { get; set; }
        public int RoleId { get; set; }
        public int ModuleId { get; set; }
        public int PermissionId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblUmModules Module { get; set; }
        public virtual LkpPermissions Permission { get; set; }
        public virtual TblRoles Role { get; set; }
    }
}

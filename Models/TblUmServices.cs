using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblUmServices
    {
        public TblUmServices()
        {
            TblRoleServices = new HashSet<TblRoleServices>();
            TblUmServiceUrls = new HashSet<TblUmServiceUrls>();
        }

        public int ServiceId { get; set; }
        public string Name { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public int ModuleId { get; set; }
        public string Command { get; set; }
        public int? OrderBy { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblUmModules Module { get; set; }
        public virtual ICollection<TblRoleServices> TblRoleServices { get; set; }
        public virtual ICollection<TblUmServiceUrls> TblUmServiceUrls { get; set; }
    }
}

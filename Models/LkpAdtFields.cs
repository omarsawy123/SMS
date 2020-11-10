using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpAdtFields
    {
        public LkpAdtFields()
        {
            TblAuditTrails = new HashSet<TblAuditTrails>();
        }

        public int FieldId { get; set; }
        public int SubModuleId { get; set; }
        public string Code { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public bool IsOperationTask { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpAdtSubModules SubModule { get; set; }
        public virtual ICollection<TblAuditTrails> TblAuditTrails { get; set; }
    }
}

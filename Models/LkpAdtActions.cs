﻿using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpAdtActions
    {
        public LkpAdtActions()
        {
            TblAuditTrails = new HashSet<TblAuditTrails>();
        }

        public int ActionId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string Code { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblAuditTrails> TblAuditTrails { get; set; }
    }
}

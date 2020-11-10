using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblAuditTrails
    {
        public int AuditTrailId { get; set; }
        public int FieldId { get; set; }
        public int ActionId { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string OldName { get; set; }
        public string NewName { get; set; }
        public string InvoiceNumber { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpAdtActions Action { get; set; }
        public virtual LkpAdtFields Field { get; set; }
    }
}

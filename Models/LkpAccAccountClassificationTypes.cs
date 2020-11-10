using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpAccAccountClassificationTypes
    {
        public LkpAccAccountClassificationTypes()
        {
            LkpAccAccountTypes = new HashSet<LkpAccAccountTypes>();
        }

        public int AccountClassificationTypeId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<LkpAccAccountTypes> LkpAccAccountTypes { get; set; }
    }
}

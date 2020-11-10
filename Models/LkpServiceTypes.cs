using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpServiceTypes
    {
        public LkpServiceTypes()
        {
            LkpServices = new HashSet<LkpServices>();
        }

        public int ServiceTypeId { get; set; }
        public string Code { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<LkpServices> LkpServices { get; set; }
    }
}

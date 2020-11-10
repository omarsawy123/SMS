using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpReceivingTerms
    {
        public int ReceivingTermId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public bool IsDefault { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
    }
}

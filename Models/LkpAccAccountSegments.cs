using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpAccAccountSegments
    {
        public LkpAccAccountSegments()
        {
            TblAccAccounts = new HashSet<TblAccAccounts>();
        }

        public int AccountSegmentId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int LevelOrder { get; set; }
        public int ZeroPadding { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblAccAccounts> TblAccAccounts { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpEventStates
    {
        public LkpEventStates()
        {
            TblUserEvents = new HashSet<TblUserEvents>();
        }

        public int EventStatusId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblUserEvents> TblUserEvents { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpDebitTypes
    {
        public LkpDebitTypes()
        {
            TblDebitNotes = new HashSet<TblDebitNotes>();
        }

        public int DebitTypeId { get; set; }
        public string Name { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblDebitNotes> TblDebitNotes { get; set; }
    }
}

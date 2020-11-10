using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblDebitNoteJournals
    {
        public int DebitNoteId { get; set; }
        public int JournalId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblDebitNotes DebitNote { get; set; }
        public virtual TblAccJournals Journal { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblDebitNoteDetails
    {
        public int DebitNoteDetailId { get; set; }
        public int DebitNoteId { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal Quantity { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblDebitNotes DebitNote { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpHscodes
    {
        public LkpHscodes()
        {
            TblBookingDetails = new HashSet<TblBookingDetails>();
            TblQuoteDetails = new HashSet<TblQuoteDetails>();
        }

        public int HscodeId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblBookingDetails> TblBookingDetails { get; set; }
        public virtual ICollection<TblQuoteDetails> TblQuoteDetails { get; set; }
    }
}

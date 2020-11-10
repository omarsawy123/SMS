using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpDeliveryTerms
    {
        public LkpDeliveryTerms()
        {
            TblBookings = new HashSet<TblBookings>();
        }

        public int DeliveryTermId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public bool IsDefault { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblBookings> TblBookings { get; set; }
    }
}

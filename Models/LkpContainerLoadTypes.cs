using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpContainerLoadTypes
    {
        public LkpContainerLoadTypes()
        {
            TblBookingDetails = new HashSet<TblBookingDetails>();
        }

        public int ContainerLoadTypeId { get; set; }
        public string Name { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblBookingDetails> TblBookingDetails { get; set; }
    }
}

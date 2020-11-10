using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpHouseConsolidationCodes
    {
        public LkpHouseConsolidationCodes()
        {
            TblBookings = new HashSet<TblBookings>();
        }

        public int HouseConsolidationCodeId { get; set; }
        public string Code { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblBookings> TblBookings { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblShipTypeTest
    {
        public TblShipTypeTest()
        {
            TblShipTest = new HashSet<TblShipTest>();
        }

        public int ShipTypeId { get; set; }
        public string ShipTypeName { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblShipTest> TblShipTest { get; set; }
    }
}

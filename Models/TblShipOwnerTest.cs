using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblShipOwnerTest
    {
        public TblShipOwnerTest()
        {
            TblShipTest = new HashSet<TblShipTest>();
        }

        public int ShipOwnerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblShipTest> TblShipTest { get; set; }
    }
}

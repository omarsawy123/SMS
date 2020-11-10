using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblShipTest
    {
        public int ShipId { get; set; }
        public string Name { get; set; }
        public double? Width { get; set; }
        public string CallSign { get; set; }
        public int? ShipOwnerId { get; set; }
        public int? ShipTypeId { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual TblShipOwnerTest ShipOwner { get; set; }
        public virtual TblShipTypeTest ShipType { get; set; }
    }
}

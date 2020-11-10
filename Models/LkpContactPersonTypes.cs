using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpContactPersonTypes
    {
        public LkpContactPersonTypes()
        {
            TblClientContactPersons = new HashSet<TblClientContactPersons>();
            TblSupplierContactPersons = new HashSet<TblSupplierContactPersons>();
        }

        public int ContactPersonTypeId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblClientContactPersons> TblClientContactPersons { get; set; }
        public virtual ICollection<TblSupplierContactPersons> TblSupplierContactPersons { get; set; }
    }
}

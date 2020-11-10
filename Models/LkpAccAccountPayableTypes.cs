using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpAccAccountPayableTypes
    {
        public LkpAccAccountPayableTypes()
        {
            TblAccAccountPayables = new HashSet<TblAccAccountPayables>();
        }

        public int AccountPayableTypeId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public string ResetPayablePrefix { get; set; }
        public int ResetPayableZeroPadding { get; set; }
        public int ResetPayableLastSerial { get; set; }
        public bool IsDefault { get; set; }

        public virtual ICollection<TblAccAccountPayables> TblAccAccountPayables { get; set; }
    }
}

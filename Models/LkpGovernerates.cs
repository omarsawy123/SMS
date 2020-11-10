using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpGovernerates
    {
        public LkpGovernerates()
        {
            LkpAreas = new HashSet<LkpAreas>();
            TblClients = new HashSet<TblClients>();
            TblEmployees = new HashSet<TblEmployees>();
        }

        public int GovernerateId { get; set; }
        public string NameFr { get; set; }
        public string NameAr { get; set; }
        public bool IsDefault { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public string NameEn { get; set; }
        public int CountryId { get; set; }

        public virtual LkpCountries Country { get; set; }
        public virtual ICollection<LkpAreas> LkpAreas { get; set; }
        public virtual ICollection<TblClients> TblClients { get; set; }
        public virtual ICollection<TblEmployees> TblEmployees { get; set; }
    }
}

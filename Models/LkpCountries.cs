using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpCountries
    {
        public LkpCountries()
        {
            LkpGovernerates = new HashSet<LkpGovernerates>();
            LkpPorts = new HashSet<LkpPorts>();
            TblClients = new HashSet<TblClients>();
            TblContractedLines = new HashSet<TblContractedLines>();
        }

        public int CountryId { get; set; }
        public string Code { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<LkpGovernerates> LkpGovernerates { get; set; }
        public virtual ICollection<LkpPorts> LkpPorts { get; set; }
        public virtual ICollection<TblClients> TblClients { get; set; }
        public virtual ICollection<TblContractedLines> TblContractedLines { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpBanks
    {
        public LkpBanks()
        {
            LkpBankAccounts = new HashSet<LkpBankAccounts>();
        }

        public int BankId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<LkpBankAccounts> LkpBankAccounts { get; set; }
    }
}

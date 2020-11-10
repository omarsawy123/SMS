using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblAccAccountCurrencyLinks
    {
        public int FixedAccountId { get; set; }
        public int AccountId { get; set; }
        public int CurrencyId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblAccAccounts Account { get; set; }
        public virtual LkpCurrencies Currency { get; set; }
        public virtual LkpAccFixedAccounts FixedAccount { get; set; }
    }
}

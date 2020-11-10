using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblContractedLineCurrencies
    {
        public int ContractedLineCurrencyId { get; set; }
        public int ContractedLineId { get; set; }
        public int? AccountId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int CurrencyId { get; set; }

        public virtual TblAccAccounts Account { get; set; }
        public virtual TblContractedLines ContractedLine { get; set; }
        public virtual LkpCurrencies Currency { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblTransfers
    {
        public TblTransfers()
        {
            TblTransferJournals = new HashSet<TblTransferJournals>();
        }

        public int TransferId { get; set; }
        public int TransferSerial { get; set; }
        public int? FromTreasuryId { get; set; }
        public int? ToTreasuryId { get; set; }
        public int? FromBankAccountId { get; set; }
        public int? ToBankAccountId { get; set; }
        public decimal TransferValue { get; set; }
        public int FinancialYearId { get; set; }
        public int CurrencyId { get; set; }
        public DateTime TransferDate { get; set; }
        public bool IsWaitingJournalGeneration { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpCurrencies Currency { get; set; }
        public virtual LkpFinancialYears FinancialYear { get; set; }
        public virtual LkpBankAccounts FromBankAccount { get; set; }
        public virtual LkpAccTreasuries FromTreasury { get; set; }
        public virtual LkpBankAccounts ToBankAccount { get; set; }
        public virtual LkpAccTreasuries ToTreasury { get; set; }
        public virtual ICollection<TblTransferJournals> TblTransferJournals { get; set; }
    }
}

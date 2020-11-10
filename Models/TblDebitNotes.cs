using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblDebitNotes
    {
        public TblDebitNotes()
        {
            TblDebitNoteDetails = new HashSet<TblDebitNoteDetails>();
            TblDebitNoteJournals = new HashSet<TblDebitNoteJournals>();
        }

        public int DebitNoteId { get; set; }
        public int ContractedLineId { get; set; }
        public int DebitTypeId { get; set; }
        public string ContractedLineName { get; set; }
        public DateTime? DebitDate { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string DebitNoteNumber { get; set; }
        public int DebitNoteNumberCount { get; set; }
        public int CurrencyId { get; set; }
        public int? BankAccountId { get; set; }
        public int? TreasuryId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool IsWaitingJournalGeneration { get; set; }
        public int FinancialYearId { get; set; }

        public virtual LkpBankAccounts BankAccount { get; set; }
        public virtual TblContractedLines ContractedLine { get; set; }
        public virtual LkpCurrencies Currency { get; set; }
        public virtual LkpDebitTypes DebitType { get; set; }
        public virtual LkpFinancialYears FinancialYear { get; set; }
        public virtual LkpAccTreasuries Treasury { get; set; }
        public virtual ICollection<TblDebitNoteDetails> TblDebitNoteDetails { get; set; }
        public virtual ICollection<TblDebitNoteJournals> TblDebitNoteJournals { get; set; }
    }
}

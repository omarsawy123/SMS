using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpBankAccounts
    {
        public LkpBankAccounts()
        {
            TblAccAccountPayables = new HashSet<TblAccAccountPayables>();
            TblDebitNotes = new HashSet<TblDebitNotes>();
            TblInvoicePayments = new HashSet<TblInvoicePayments>();
            TblStudentPayments = new HashSet<TblStudentPayments>();
            TblTransfersFromBankAccount = new HashSet<TblTransfers>();
            TblTransfersToBankAccount = new HashSet<TblTransfers>();
        }

        public int BankAccountId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int BankId { get; set; }
        public int CurrencyId { get; set; }
        public int? AccountId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsRunningAccount { get; set; }

        public virtual TblAccAccounts Account { get; set; }
        public virtual LkpBanks Bank { get; set; }
        public virtual LkpCurrencies Currency { get; set; }
        public virtual ICollection<TblAccAccountPayables> TblAccAccountPayables { get; set; }
        public virtual ICollection<TblDebitNotes> TblDebitNotes { get; set; }
        public virtual ICollection<TblInvoicePayments> TblInvoicePayments { get; set; }
        public virtual ICollection<TblStudentPayments> TblStudentPayments { get; set; }
        public virtual ICollection<TblTransfers> TblTransfersFromBankAccount { get; set; }
        public virtual ICollection<TblTransfers> TblTransfersToBankAccount { get; set; }
    }
}

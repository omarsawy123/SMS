using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblAccJournalDetails
    {
        public TblAccJournalDetails()
        {
            TblAccountUserDefinedSharePercentages = new HashSet<TblAccountUserDefinedSharePercentages>();
        }

        public int JournalDetailId { get; set; }
        public int? JournalId { get; set; }
        public int AccountId { get; set; }
        public bool IsDebitAccount { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public int? ClientId { get; set; }
        public int? SupplierId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblAccAccounts Account { get; set; }
        public virtual TblClients Client { get; set; }
        public virtual TblAccJournals Journal { get; set; }
        public virtual TblServiceProviders Supplier { get; set; }
        public virtual ICollection<TblAccountUserDefinedSharePercentages> TblAccountUserDefinedSharePercentages { get; set; }
    }
}

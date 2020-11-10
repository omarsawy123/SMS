using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblContractedLines
    {
        public TblContractedLines()
        {
            TblContractedLineCurrencies = new HashSet<TblContractedLineCurrencies>();
            TblDebitNotes = new HashSet<TblDebitNotes>();
        }

        public int ContractedLineId { get; set; }
        public string Name { get; set; }
        public int? CountryId { get; set; }
        public string Address { get; set; }
        public string StateName { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpCountries Country { get; set; }
        public virtual ICollection<TblContractedLineCurrencies> TblContractedLineCurrencies { get; set; }
        public virtual ICollection<TblDebitNotes> TblDebitNotes { get; set; }
    }
}

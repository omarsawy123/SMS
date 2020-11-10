using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpAccTreasuries
    {
        public LkpAccTreasuries()
        {
            LkpAccTreasuryCurrencies = new HashSet<LkpAccTreasuryCurrencies>();
            TblAccAccountPayables = new HashSet<TblAccAccountPayables>();
            TblDebitNotes = new HashSet<TblDebitNotes>();
            TblInvoicePayments = new HashSet<TblInvoicePayments>();
            TblStudentPayments = new HashSet<TblStudentPayments>();
            TblTransfersFromTreasury = new HashSet<TblTransfers>();
            TblTransfersToTreasury = new HashSet<TblTransfers>();
        }

        public int TreasuryId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int? BranchId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public string ResetReceivablePrefix { get; set; }
        public int ResetReceivableZeroPadding { get; set; }
        public int ResetReceivableLastSerial { get; set; }
        public string ResetPayablePrefix { get; set; }
        public int ResetPayableZeroPadding { get; set; }
        public int ResetPayableLastSerial { get; set; }

        public virtual LkpBranches Branch { get; set; }
        public virtual ICollection<LkpAccTreasuryCurrencies> LkpAccTreasuryCurrencies { get; set; }
        public virtual ICollection<TblAccAccountPayables> TblAccAccountPayables { get; set; }
        public virtual ICollection<TblDebitNotes> TblDebitNotes { get; set; }
        public virtual ICollection<TblInvoicePayments> TblInvoicePayments { get; set; }
        public virtual ICollection<TblStudentPayments> TblStudentPayments { get; set; }
        public virtual ICollection<TblTransfers> TblTransfersFromTreasury { get; set; }
        public virtual ICollection<TblTransfers> TblTransfersToTreasury { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpBranches
    {
        public LkpBranches()
        {
            LkpAccTreasuries = new HashSet<LkpAccTreasuries>();
            TblAccAccountPayables = new HashSet<TblAccAccountPayables>();
            TblAccSupplierInvoices = new HashSet<TblAccSupplierInvoices>();
            TblBookings = new HashSet<TblBookings>();
            TblInvoices = new HashSet<TblInvoices>();
            TblQuotes = new HashSet<TblQuotes>();
            TblUsers = new HashSet<TblUsers>();
        }

        public int BranchId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<LkpAccTreasuries> LkpAccTreasuries { get; set; }
        public virtual ICollection<TblAccAccountPayables> TblAccAccountPayables { get; set; }
        public virtual ICollection<TblAccSupplierInvoices> TblAccSupplierInvoices { get; set; }
        public virtual ICollection<TblBookings> TblBookings { get; set; }
        public virtual ICollection<TblInvoices> TblInvoices { get; set; }
        public virtual ICollection<TblQuotes> TblQuotes { get; set; }
        public virtual ICollection<TblUsers> TblUsers { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblStudentPayments
    {
        public TblStudentPayments()
        {
            TblStudentPaymentReceivables = new HashSet<TblStudentPaymentReceivables>();
        }

        public int StudentPaymentId { get; set; }
        public int StudentAcademicYearId { get; set; }
        public int SerialNumber { get; set; }
        public int AcademicYearId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string ReceiptNumber { get; set; }
        public int PaymentMethodId { get; set; }
        public int PaymentPortionTypeId { get; set; }
        public string Remarks { get; set; }
        public string ReceiptNumberOther { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int? TreasuryId { get; set; }
        public int? BankAccountId { get; set; }
        public string BankReceiptNo { get; set; }

        public virtual LkpBankAccounts BankAccount { get; set; }
        public virtual LkpInvoicePaymentMethods PaymentMethod { get; set; }
        public virtual LkpPaymentPortionTypes PaymentPortionType { get; set; }
        public virtual TblStudentAcademicYears StudentAcademicYear { get; set; }
        public virtual LkpAccTreasuries Treasury { get; set; }
        public virtual ICollection<TblStudentPaymentReceivables> TblStudentPaymentReceivables { get; set; }
    }
}

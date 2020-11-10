using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblStudentAcademicYears
    {
        public TblStudentAcademicYears()
        {
            TblStudentPayments = new HashSet<TblStudentPayments>();
            TblStudentSemesters = new HashSet<TblStudentSemesters>();
        }

        public int StudentAcademicYearId { get; set; }
        public int AcademicYearId { get; set; }
        public int StudentId { get; set; }
        public int GradeId { get; set; }
        public int ClassId { get; set; }
        public int StudentStatusId { get; set; }
        public int? StudentCode { get; set; }
        public int? SeatNumber { get; set; }
        public int FirstPaymentStatusId { get; set; }
        public int SecondPaymentStatusId { get; set; }
        public int? SectionId { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsAbsent { get; set; }
        public string StudentStatusNote { get; set; }
        public int? PaymentDiscountTypeId { get; set; }
        public decimal? PaymentDiscountValue { get; set; }
        public string PaymentRemarks { get; set; }
        public int? OnlyPayPortionTypeId { get; set; }

        public virtual LkpAcademicYears AcademicYear { get; set; }
        public virtual LkpClasses Class { get; set; }
        public virtual LkpPaymentStates FirstPaymentStatus { get; set; }
        public virtual LkpGrades Grade { get; set; }
        public virtual LkpPaymentPortionTypes OnlyPayPortionType { get; set; }
        public virtual LkpPaymentDiscountTypes PaymentDiscountType { get; set; }
        public virtual LkpPaymentStates SecondPaymentStatus { get; set; }
        public virtual LkpSections Section { get; set; }
        public virtual TblStudents Student { get; set; }
        public virtual LkpStudentStates StudentStatus { get; set; }
        public virtual ICollection<TblStudentPayments> TblStudentPayments { get; set; }
        public virtual ICollection<TblStudentSemesters> TblStudentSemesters { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpAcademicYears
    {
        public LkpAcademicYears()
        {
            LkpAcademicYearExams = new HashSet<LkpAcademicYearExams>();
            TblExpenses = new HashSet<TblExpenses>();
            TblSemesterAbsencePeriods = new HashSet<TblSemesterAbsencePeriods>();
            TblStudentAbsences = new HashSet<TblStudentAbsences>();
            TblStudentAcademicYears = new HashSet<TblStudentAcademicYears>();
            TblStudentWaitingLists = new HashSet<TblStudentWaitingLists>();
        }

        public int AcademicYearId { get; set; }
        public int Year { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public string DateOfSummerExams { get; set; }
        public bool IsCurrent { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsWaitingListsDefault { get; set; }
        public bool ComputeStudentAbsence { get; set; }

        public virtual ICollection<LkpAcademicYearExams> LkpAcademicYearExams { get; set; }
        public virtual ICollection<TblExpenses> TblExpenses { get; set; }
        public virtual ICollection<TblSemesterAbsencePeriods> TblSemesterAbsencePeriods { get; set; }
        public virtual ICollection<TblStudentAbsences> TblStudentAbsences { get; set; }
        public virtual ICollection<TblStudentAcademicYears> TblStudentAcademicYears { get; set; }
        public virtual ICollection<TblStudentWaitingLists> TblStudentWaitingLists { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblStudentWaitingLists
    {
        public TblStudentWaitingLists()
        {
            TblStudentWaitingListSisters = new HashSet<TblStudentWaitingListSisters>();
        }

        public int StudentWaitingListId { get; set; }
        public string FileNumber { get; set; }
        public int CodeCount { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public DateTime DateOfBrith { get; set; }
        public string LocationOfBirth { get; set; }
        public int ReligionId { get; set; }
        public int GenderTypeId { get; set; }
        public int NationalityId { get; set; }
        public int? FatherQualificationId { get; set; }
        public int? MotherQualificationId { get; set; }
        public string FatherJob { get; set; }
        public string FatherMobile { get; set; }
        public string FatherWorkTelephone { get; set; }
        public bool IsFatherDied { get; set; }
        public string MotherName { get; set; }
        public string MotherJob { get; set; }
        public string MotherMobile { get; set; }
        public string MotherWorkTelephone { get; set; }
        public bool IsMotherDied { get; set; }
        public int? ParentStatusId { get; set; }
        public string NationalIdnumber { get; set; }
        public string Email { get; set; }
        public string FatherEmail { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public int AreaId { get; set; }
        public string Telephone { get; set; }
        public int AcademicYearId { get; set; }
        public int PaymentStatusId { get; set; }
        public int WaitingListStatusId { get; set; }
        public int? StudentId { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public string OfficialRegistrationNumber { get; set; }
        public DateTime? OfficialRegistrationDate { get; set; }
        public string FatherName { get; set; }
        public string FirstNameAr { get; set; }
        public string FatherNationalIdnumber { get; set; }

        public virtual LkpAcademicYears AcademicYear { get; set; }
        public virtual LkpAreas Area { get; set; }
        public virtual LkpQualifications FatherQualification { get; set; }
        public virtual LkpGenderTypes GenderType { get; set; }
        public virtual LkpQualifications MotherQualification { get; set; }
        public virtual LkpNationalities Nationality { get; set; }
        public virtual LkpParentStates ParentStatus { get; set; }
        public virtual LkpPaymentStates PaymentStatus { get; set; }
        public virtual LkpReligions Religion { get; set; }
        public virtual TblStudents Student { get; set; }
        public virtual LkpWaitingListStates WaitingListStatus { get; set; }
        public virtual ICollection<TblStudentWaitingListSisters> TblStudentWaitingListSisters { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblStudents
    {
        public TblStudents()
        {
            TblStudentAbsences = new HashSet<TblStudentAbsences>();
            TblStudentAcademicYears = new HashSet<TblStudentAcademicYears>();
            TblStudentAttachments = new HashSet<TblStudentAttachments>();
            TblStudentContacts = new HashSet<TblStudentContacts>();
            TblStudentMedicalHistories = new HashSet<TblStudentMedicalHistories>();
            TblStudentSistersSister = new HashSet<TblStudentSisters>();
            TblStudentSistersStudent = new HashSet<TblStudentSisters>();
            TblStudentWaitingListSisters = new HashSet<TblStudentWaitingListSisters>();
            TblStudentWaitingLists = new HashSet<TblStudentWaitingLists>();
        }

        public int StudentId { get; set; }
        public string Code { get; set; }
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
        public string FatherJob { get; set; }
        public bool IsFatherDied { get; set; }
        public string MotherName { get; set; }
        public int? MotherQualificationId { get; set; }
        public string MotherJob { get; set; }
        public bool IsMotherDied { get; set; }
        public int? ParentStatusId { get; set; }
        public string NationalIdnumber { get; set; }
        public string Email { get; set; }
        public string SchoolEmail { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string PhotoFileName { get; set; }
        public string PrivateNotes { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public string IntegrationId { get; set; }
        public string FatherWorkTelephone { get; set; }
        public string MotherWorkTelephone { get; set; }
        public int? AreaId { get; set; }
        public string FatherMobile { get; set; }
        public string MotherMobile { get; set; }
        public DateTime? OfficialRegistrationDate { get; set; }
        public string OfficialRegistrationNumber { get; set; }
        public string FatherName { get; set; }
        public string FirstNameAr { get; set; }
        public string FatherNationalIdnumber { get; set; }
        public bool? HasResponsible { get; set; }
        public string ResponsibleName { get; set; }
        public int? StudentResponsibleRelationId { get; set; }
        public string ResponsibleTelephone { get; set; }
        public string ResponsibleAddress { get; set; }
        public string ResponsibleMobile { get; set; }

        public virtual LkpAreas Area { get; set; }
        public virtual LkpQualifications FatherQualification { get; set; }
        public virtual LkpGenderTypes GenderType { get; set; }
        public virtual LkpQualifications MotherQualification { get; set; }
        public virtual LkpNationalities Nationality { get; set; }
        public virtual LkpParentStates ParentStatus { get; set; }
        public virtual LkpReligions Religion { get; set; }
        public virtual LkpStudentResponsibleRelations StudentResponsibleRelation { get; set; }
        public virtual ICollection<TblStudentAbsences> TblStudentAbsences { get; set; }
        public virtual ICollection<TblStudentAcademicYears> TblStudentAcademicYears { get; set; }
        public virtual ICollection<TblStudentAttachments> TblStudentAttachments { get; set; }
        public virtual ICollection<TblStudentContacts> TblStudentContacts { get; set; }
        public virtual ICollection<TblStudentMedicalHistories> TblStudentMedicalHistories { get; set; }
        public virtual ICollection<TblStudentSisters> TblStudentSistersSister { get; set; }
        public virtual ICollection<TblStudentSisters> TblStudentSistersStudent { get; set; }
        public virtual ICollection<TblStudentWaitingListSisters> TblStudentWaitingListSisters { get; set; }
        public virtual ICollection<TblStudentWaitingLists> TblStudentWaitingLists { get; set; }
    }
}

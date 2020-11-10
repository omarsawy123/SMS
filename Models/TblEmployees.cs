using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblEmployees
    {
        public TblEmployees()
        {
            InverseDirectManagerEmployee = new HashSet<TblEmployees>();
            TblEmployeeAttachments = new HashSet<TblEmployeeAttachments>();
            TblEmployeeTeachingSubjects = new HashSet<TblEmployeeTeachingSubjects>();
            TblEmployeeVacations = new HashSet<TblEmployeeVacations>();
        }

        public int EmployeeId { get; set; }
        public string Code { get; set; }
        public int CodeCount { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public int GenderTypeId { get; set; }
        public int? MilitaryStatusId { get; set; }
        public int ReligionId { get; set; }
        public int NationalityId { get; set; }
        public string MotherName { get; set; }
        public int? MaritalStatusId { get; set; }
        public string PhotoFileName { get; set; }
        public string NationalIdnumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string LocationOfBirth { get; set; }
        public string NationalRegister { get; set; }
        public string Qualification { get; set; }
        public DateTime? DateOfBirthQualification { get; set; }
        public string EducationalQualification { get; set; }
        public DateTime? DateOfEducationalQualification { get; set; }
        public string QualificationsRemarks { get; set; }
        public bool HasIcdl { get; set; }
        public DateTime? DateOfIcdl { get; set; }
        public string AdditionalCourses { get; set; }
        public string Remarks { get; set; }
        public string Address { get; set; }
        public int? AreaId { get; set; }
        public string PostalCode { get; set; }
        public int? GovernerateId { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string PersonalEmail { get; set; }
        public string SchoolEmail { get; set; }
        public int EmployeeJobId { get; set; }
        public int EmploymentTypeId { get; set; }
        public int? DepartmentId { get; set; }
        public int? DirectManagerEmployeeId { get; set; }
        public decimal? YearsOfFieldExperienceWhenJoined { get; set; }
        public DateTime? RecruitmentDate { get; set; }
        public DateTime? ResignationDate { get; set; }
        public int InitialAnnualVacationBalance { get; set; }
        public int InitialCausalVacationBalance { get; set; }
        public decimal? SalaryValue { get; set; }
        public decimal? SalaryTaxValue { get; set; }
        public decimal? SalaryDueToRaiseValue { get; set; }
        public string InsuranceNumber { get; set; }
        public decimal? InsuranceValue { get; set; }
        public decimal? HealthInsuranceValue { get; set; }
        public string PrivateNotes { get; set; }
        public string IntegrationId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int? NumberOfChildren { get; set; }
        public DateTime? WorkJoinDate { get; set; }

        public virtual LkpAreas Area { get; set; }
        public virtual LkpDepartments Department { get; set; }
        public virtual TblEmployees DirectManagerEmployee { get; set; }
        public virtual LkpEmployeeJobs EmployeeJob { get; set; }
        public virtual LkpEmploymentTypes EmploymentType { get; set; }
        public virtual LkpGenderTypes GenderType { get; set; }
        public virtual LkpGovernerates Governerate { get; set; }
        public virtual LkpMaritalStates MaritalStatus { get; set; }
        public virtual LkpMilitaryStates MilitaryStatus { get; set; }
        public virtual LkpNationalities Nationality { get; set; }
        public virtual LkpReligions Religion { get; set; }
        public virtual ICollection<TblEmployees> InverseDirectManagerEmployee { get; set; }
        public virtual ICollection<TblEmployeeAttachments> TblEmployeeAttachments { get; set; }
        public virtual ICollection<TblEmployeeTeachingSubjects> TblEmployeeTeachingSubjects { get; set; }
        public virtual ICollection<TblEmployeeVacations> TblEmployeeVacations { get; set; }
    }
}

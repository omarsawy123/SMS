using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblStudentMedicalHistories
    {
        public int StudentMedicalHistoriyId { get; set; }
        public int StudentId { get; set; }
        public int DiseaseTypeId { get; set; }
        public string DiseaseName { get; set; }
        public string Remarks { get; set; }
        public string EmergencyRemarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpDiseaseTypes DiseaseType { get; set; }
        public virtual TblStudents Student { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpDiseaseTypes
    {
        public LkpDiseaseTypes()
        {
            TblStudentMedicalHistories = new HashSet<TblStudentMedicalHistories>();
        }

        public int DiseaseTypeId { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblStudentMedicalHistories> TblStudentMedicalHistories { get; set; }
    }
}

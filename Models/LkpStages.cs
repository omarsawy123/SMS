using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpStages
    {
        public LkpStages()
        {
            LkpGrades = new HashSet<LkpGrades>();
            LkpMonthDegreeFunctions = new HashSet<LkpMonthDegreeFunctions>();
            LkpReportsDegreeFunctions = new HashSet<LkpReportsDegreeFunctions>();
            LkpTermDegreeFunctions = new HashSet<LkpTermDegreeFunctions>();
        }

        public int StageId { get; set; }
        public string Code { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public string IntegrationId { get; set; }
        public int? StudyOrder { get; set; }
        public string SecretaryNameFr { get; set; }
        public string SecretaryNameAr { get; set; }

        public virtual ICollection<LkpGrades> LkpGrades { get; set; }
        public virtual ICollection<LkpMonthDegreeFunctions> LkpMonthDegreeFunctions { get; set; }
        public virtual ICollection<LkpReportsDegreeFunctions> LkpReportsDegreeFunctions { get; set; }
        public virtual ICollection<LkpTermDegreeFunctions> LkpTermDegreeFunctions { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpGeneralEvaluations
    {
        public int GeneralEvaluationId { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public decimal? LessThan { get; set; }
        public decimal? GreaterThan { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
    }
}

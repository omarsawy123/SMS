using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class ViwLkpGrades
    {
        public int GradeId { get; set; }
        public string FrenchName { get; set; }
        public string ArabicName { get; set; }
        public bool IsDeleted { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpColorDegrees
    {
        public LkpColorDegrees()
        {
            TblStudentDegrees = new HashSet<TblStudentDegrees>();
        }

        public int ColorDegreeId { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string Color { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblStudentDegrees> TblStudentDegrees { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblStudentSisters
    {
        public int StudentSisterId { get; set; }
        public int StudentId { get; set; }
        public int SisterId { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblStudents Sister { get; set; }
        public virtual TblStudents Student { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblUserClasses
    {
        public int UserClassId { get; set; }
        public int UserSubjectId { get; set; }
        public int ClassId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpClasses Class { get; set; }
        public virtual TblUserSubjects UserSubject { get; set; }
    }
}

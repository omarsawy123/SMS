using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblUserSubjects
    {
        public TblUserSubjects()
        {
            TblUserClasses = new HashSet<TblUserClasses>();
        }

        public int UserId { get; set; }
        public int SubjectId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int UserSubjectId { get; set; }

        public virtual LkpSubjects Subject { get; set; }
        public virtual TblUsers User { get; set; }
        public virtual ICollection<TblUserClasses> TblUserClasses { get; set; }
    }
}

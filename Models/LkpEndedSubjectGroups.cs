using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpEndedSubjectGroups
    {
        public LkpEndedSubjectGroups()
        {
            LkpSubjects = new HashSet<LkpSubjects>();
        }

        public int EndedSubjectGroupId { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int? DisplayOrder { get; set; }

        public virtual ICollection<LkpSubjects> LkpSubjects { get; set; }
    }
}

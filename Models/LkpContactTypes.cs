using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpContactTypes
    {
        public LkpContactTypes()
        {
            TblStudentContacts = new HashSet<TblStudentContacts>();
        }

        public int ContactTypeId { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblStudentContacts> TblStudentContacts { get; set; }
    }
}

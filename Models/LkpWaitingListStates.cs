using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpWaitingListStates
    {
        public LkpWaitingListStates()
        {
            TblStudentWaitingLists = new HashSet<TblStudentWaitingLists>();
        }

        public int WaitingListStatusId { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public bool IsDefault { get; set; }
        public int? DisplayOrder { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblStudentWaitingLists> TblStudentWaitingLists { get; set; }
    }
}

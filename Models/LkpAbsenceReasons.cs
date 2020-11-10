using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpAbsenceReasons
    {
        public LkpAbsenceReasons()
        {
            TblStudentAbsences = new HashSet<TblStudentAbsences>();
        }

        public int AbsentReasonId { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string NameFr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public bool BecauseOfLateComming { get; set; }
        public bool? ConsideredAsAbsentDay { get; set; }

        public virtual ICollection<TblStudentAbsences> TblStudentAbsences { get; set; }
    }
}

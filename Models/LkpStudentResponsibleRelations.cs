using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpStudentResponsibleRelations
    {
        public LkpStudentResponsibleRelations()
        {
            TblStudents = new HashSet<TblStudents>();
        }

        public int StudentResponsibleRelationId { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string NameFr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblStudents> TblStudents { get; set; }
    }
}

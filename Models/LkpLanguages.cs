using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpLanguages
    {
        public LkpLanguages()
        {
            TblRptLocalization = new HashSet<TblRptLocalization>();
        }

        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int LanguageIndex { get; set; }

        public virtual ICollection<TblRptLocalization> TblRptLocalization { get; set; }
    }
}

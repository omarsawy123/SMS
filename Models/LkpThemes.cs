using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpThemes
    {
        public LkpThemes()
        {
            TblUsers = new HashSet<TblUsers>();
        }

        public int ThemeId { get; set; }
        public string NameEn { get; set; }
        public string FilePath { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblUsers> TblUsers { get; set; }
    }
}

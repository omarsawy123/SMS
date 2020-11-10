using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblRptLocalization
    {
        public string ResourceKey { get; set; }
        public int LanguageId { get; set; }
        public string Value { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpLanguages Language { get; set; }
    }
}

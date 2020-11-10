using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblAstAssetActionJournals
    {
        public int AssetActionId { get; set; }
        public int IsGroupedJournal { get; set; }
        public int JournalId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblAstAssetActions AssetAction { get; set; }
        public virtual TblAccJournals Journal { get; set; }
    }
}

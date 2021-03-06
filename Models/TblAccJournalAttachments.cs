﻿using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblAccJournalAttachments
    {
        public int JournalAttachmentId { get; set; }
        public int JournalId { get; set; }
        public string DocumentName { get; set; }
        public string FormNumber { get; set; }
        public string Remarks { get; set; }
        public string FileName { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblAccJournals Journal { get; set; }
    }
}

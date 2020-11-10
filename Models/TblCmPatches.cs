using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblCmPatches
    {
        public string VersionNumber { get; set; }
        public string PatchNumber { get; set; }
        public DateTime? SentDate { get; set; }
        public DateTime ApplyDate { get; set; }
        public bool HasDbstructure { get; set; }
        public bool HasDbdata { get; set; }
        public bool HasCodeChanges { get; set; }
        public string Comment { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
    }
}

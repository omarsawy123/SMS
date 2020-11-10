using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblCmVersions
    {
        public string VersionNumber { get; set; }
        public string NextVersionNumber { get; set; }
        public string BuildNumber { get; set; }
        public bool CurrentVersion { get; set; }
        public string RevisionNumber { get; set; }
        public DateTime? SentDate { get; set; }
        public DateTime ApplyDate { get; set; }
        public string Comment { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
    }
}

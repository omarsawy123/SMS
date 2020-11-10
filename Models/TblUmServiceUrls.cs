using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblUmServiceUrls
    {
        public int ServiceUrlid { get; set; }
        public string Name { get; set; }
        public int ServiceId { get; set; }
        public string ServiceUrl { get; set; }
        public int? OrderBy { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblUmServices Service { get; set; }
    }
}

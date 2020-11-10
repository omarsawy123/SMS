using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpTafkitas
    {
        public decimal Cod { get; set; }
        public decimal Loc { get; set; }
        public string Name { get; set; }
        public string NameE { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
    }
}

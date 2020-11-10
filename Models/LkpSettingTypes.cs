using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpSettingTypes
    {
        public LkpSettingTypes()
        {
            TblSettings = new HashSet<TblSettings>();
        }

        public int SettingTypeId { get; set; }
        public string Name { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<TblSettings> TblSettings { get; set; }
    }
}

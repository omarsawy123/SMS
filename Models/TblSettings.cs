using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblSettings
    {
        public string ItemName { get; set; }
        public string DisplayName { get; set; }
        public string ItemValue { get; set; }
        public string DataType { get; set; }
        public int SettingTypeId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpSettingTypes SettingType { get; set; }
    }
}

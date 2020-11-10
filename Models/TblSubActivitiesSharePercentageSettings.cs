using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblSubActivitiesSharePercentageSettings
    {
        public int SubActivitiesSharePercentageSettingId { get; set; }
        public int SubActivityId { get; set; }
        public decimal Percentage { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime FromDate { get; set; }
        public int AccountShareSettingId { get; set; }

        public virtual TblAccountShareSettings AccountShareSetting { get; set; }
        public virtual LkpSubActivity SubActivity { get; set; }
    }
}

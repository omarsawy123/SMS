using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblAccountShareSettings
    {
        public TblAccountShareSettings()
        {
            TblSubActivitiesSharePercentageSettings = new HashSet<TblSubActivitiesSharePercentageSettings>();
        }

        public int AccountShareSettingId { get; set; }
        public int AccountId { get; set; }
        public bool? IsDistributedWithFixedPercentage { get; set; }
        public bool? IsDistributedToAllSubActivities { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblAccAccounts Account { get; set; }
        public virtual ICollection<TblSubActivitiesSharePercentageSettings> TblSubActivitiesSharePercentageSettings { get; set; }
    }
}

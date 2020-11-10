using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpGradesParentNotifications
    {
        public int GradesParentNotificationId { get; set; }
        public int GradeId { get; set; }
        public string NotificationText { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpGrades Grade { get; set; }
    }
}

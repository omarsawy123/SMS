using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpWaitingListReports
    {
        public int WaitingListReportId { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public string WhereConditionExpression { get; set; }
        public string OrderByExpression { get; set; }
        public bool IsDefault { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public bool? EnableSearchByBirthDate { get; set; }
        public string ReportUrl { get; set; }
        public string SortTitle { get; set; }
        public bool? ShowYearInSortTitle { get; set; }
        public string NameEn { get; set; }
    }
}

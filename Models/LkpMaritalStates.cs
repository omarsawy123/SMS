﻿using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpMaritalStates
    {
        public LkpMaritalStates()
        {
            TblEmployees = new HashSet<TblEmployees>();
        }

        public int MaritalStatusId { get; set; }
        public string NameAr { get; set; }
        public string NameFr { get; set; }
        public string NameEn { get; set; }
        public bool IsCurrent { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public string IntegrationId { get; set; }

        public virtual ICollection<TblEmployees> TblEmployees { get; set; }
    }
}

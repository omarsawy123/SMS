﻿using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpAdtSections
    {
        public int SectionId { get; set; }
        public int DepartmentId { get; set; }
        public string Code { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpAdtDepartments Department { get; set; }
    }
}

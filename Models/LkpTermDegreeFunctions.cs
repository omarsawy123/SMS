﻿using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpTermDegreeFunctions
    {
        public int TermDegreeFunctionId { get; set; }
        public string NameFr { get; set; }
        public string NameAr { get; set; }
        public string FunctionUrl { get; set; }
        public int StageId { get; set; }
        public bool IsDefault { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public string Semesters { get; set; }
        public string NameEn { get; set; }

        public virtual LkpStages Stage { get; set; }
    }
}

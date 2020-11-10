using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpAccAccountTypes
    {
        public LkpAccAccountTypes()
        {
            TblAccAccounts = new HashSet<TblAccAccounts>();
        }

        public int AccountTypeId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int AccountClassificationTypeId { get; set; }
        public int? DisplayOrder { get; set; }
        public int AccountCategoryId { get; set; }
        public bool IsDebitAccount { get; set; }
        public bool IsTax { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int? TshapeDisplayOrder { get; set; }
        public bool GainOrLossOfYear { get; set; }

        public virtual LkpAccAccountCategories AccountCategory { get; set; }
        public virtual LkpAccAccountClassificationTypes AccountClassificationType { get; set; }
        public virtual ICollection<TblAccAccounts> TblAccAccounts { get; set; }
    }
}

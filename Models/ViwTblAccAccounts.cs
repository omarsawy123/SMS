using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class ViwTblAccAccounts
    {
        public int AccountId { get; set; }
        public string Code { get; set; }
        public string AccountNumber { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public string AccNameEn { get; set; }
        public string AccNameAr { get; set; }
        public bool IsDeleted { get; set; }
    }
}

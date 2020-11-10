using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblGlobalSettings
    {
        public int GlobalSettingsId { get; set; }
        public string CustomerNameEn { get; set; }
        public string CustomerNameAr { get; set; }
        public string TaxNumber { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public int? CreatorUserId { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? ModifiedUserId { get; set; }
        public DateTime? LastDateModified { get; set; }
        public bool? IsDeleted { get; set; }
    }
}

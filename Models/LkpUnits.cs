using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class LkpUnits
    {
        public LkpUnits()
        {
            TblQuoteDetailsVolumeUnit = new HashSet<TblQuoteDetails>();
            TblQuoteDetailsWeightUnit = new HashSet<TblQuoteDetails>();
        }

        public int UnitId { get; set; }
        public int UnitTypeId { get; set; }
        public string Code { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public decimal ConvertionFactor { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpUnitTypes UnitType { get; set; }
        public virtual ICollection<TblQuoteDetails> TblQuoteDetailsVolumeUnit { get; set; }
        public virtual ICollection<TblQuoteDetails> TblQuoteDetailsWeightUnit { get; set; }
    }
}

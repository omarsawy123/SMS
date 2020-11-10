using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblBookingDetails
    {
        public int BookingDetailId { get; set; }
        public int BookingId { get; set; }
        public int CargoCategoryId { get; set; }
        public int? ContainerCount { get; set; }
        public int? ContainerSizeId { get; set; }
        public int? ContainerTypeId { get; set; }
        public string ContainerNumber { get; set; }
        public string SealNumber { get; set; }
        public int? Quantity { get; set; }
        public int? PackageTypeId { get; set; }
        public decimal? Weight { get; set; }
        public decimal? NetWeight { get; set; }
        public decimal? Volume { get; set; }
        public string Temperature { get; set; }
        public string ItemDescription { get; set; }
        public string MarksAndNumbers { get; set; }
        public bool IsImo { get; set; }
        public bool IsExplosives { get; set; }
        public int? ImoclassId { get; set; }
        public bool IsOog { get; set; }
        public int? HscodeId { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public decimal? RatePerKilo { get; set; }
        public int? RatePerKiloCurrencyId { get; set; }
        public int? ContainerLoadTypeId { get; set; }

        public virtual TblBookings Booking { get; set; }
        public virtual LkpCargoCategories CargoCategory { get; set; }
        public virtual LkpContainerLoadTypes ContainerLoadType { get; set; }
        public virtual LkpContainerSizes ContainerSize { get; set; }
        public virtual LkpContainerTypes ContainerType { get; set; }
        public virtual LkpHscodes Hscode { get; set; }
        public virtual LkpImoclasses Imoclass { get; set; }
        public virtual LkpPackageTypes PackageType { get; set; }
        public virtual LkpCurrencies RatePerKiloCurrency { get; set; }
    }
}

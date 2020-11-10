using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblUsers
    {
        public TblUsers()
        {
            TblAccSupplierInvoices = new HashSet<TblAccSupplierInvoices>();
            TblBookingSharing = new HashSet<TblBookingSharing>();
            TblBookingsBlockingReleaseUser = new HashSet<TblBookings>();
            TblBookingsResponsibleUser = new HashSet<TblBookings>();
            TblInvoices = new HashSet<TblInvoices>();
            TblQuotes = new HashSet<TblQuotes>();
            TblUserAbsenceResonsibleGrades = new HashSet<TblUserAbsenceResonsibleGrades>();
            TblUserEvents = new HashSet<TblUserEvents>();
            TblUserRoles = new HashSet<TblUserRoles>();
            TblUserSubjects = new HashSet<TblUserSubjects>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int BranchId { get; set; }
        public int? ThemeId { get; set; }
        public bool? IsSystemAccount { get; set; }
        public string ServiceBitMap { get; set; }
        public bool IsServiceCashed { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public int? DepartmentId { get; set; }
        public bool? ReceiveAuditingNotifications { get; set; }
        public int? SalesRegionId { get; set; }
        public bool? IsImport { get; set; }
        public int? TransportTypeId { get; set; }
        public bool? ReceiveAccountingNotifications { get; set; }
        public bool SubjectAdmin { get; set; }
        public bool IsAbsenceResbonsibleAdmin { get; set; }

        public virtual LkpBranches Branch { get; set; }
        public virtual LkpDepartments Department { get; set; }
        public virtual LkpSalesRegions SalesRegion { get; set; }
        public virtual LkpThemes Theme { get; set; }
        public virtual LkpTransportTypes TransportType { get; set; }
        public virtual ICollection<TblAccSupplierInvoices> TblAccSupplierInvoices { get; set; }
        public virtual ICollection<TblBookingSharing> TblBookingSharing { get; set; }
        public virtual ICollection<TblBookings> TblBookingsBlockingReleaseUser { get; set; }
        public virtual ICollection<TblBookings> TblBookingsResponsibleUser { get; set; }
        public virtual ICollection<TblInvoices> TblInvoices { get; set; }
        public virtual ICollection<TblQuotes> TblQuotes { get; set; }
        public virtual ICollection<TblUserAbsenceResonsibleGrades> TblUserAbsenceResonsibleGrades { get; set; }
        public virtual ICollection<TblUserEvents> TblUserEvents { get; set; }
        public virtual ICollection<TblUserRoles> TblUserRoles { get; set; }
        public virtual ICollection<TblUserSubjects> TblUserSubjects { get; set; }
    }
}

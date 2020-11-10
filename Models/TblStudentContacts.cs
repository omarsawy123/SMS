using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblStudentContacts
    {
        public int StudentContactId { get; set; }
        public int StudentId { get; set; }
        public string PersonName { get; set; }
        public string NationalIdnumber { get; set; }
        public int ContactTypeId { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public bool IsEmergency { get; set; }
        public string Remarks { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual LkpContactTypes ContactType { get; set; }
        public virtual TblStudents Student { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace SMS.Models
{
    public partial class TblMembers
    {
        public TblMembers()
        {
            TblMembersPayments = new HashSet<TblMembersPayments>();
        }

        public int MemberId { get; set; }
        public string Name { get; set; }
        public string AccessId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int? MemberAccountId { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUserId { get; set; }
        public DateTime LastDateModified { get; set; }
        public bool IsDeleted { get; set; }

        public virtual TblAccAccounts MemberAccount { get; set; }
        public virtual ICollection<TblMembersPayments> TblMembersPayments { get; set; }
    }
}

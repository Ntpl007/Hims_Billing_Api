using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblAdmAccountType
    {
        public TblAdmAccountType()
        {
            TblAccounts = new HashSet<TblAccount>();
        }

        public int AccountTypeId { get; set; }
        public string AccountTypeName { get; set; }
        public bool? ApAccount { get; set; }
        public bool? ArAccount { get; set; }
        public int StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual TblAdmStatus Status { get; set; }
        public virtual ICollection<TblAccount> TblAccounts { get; set; }
    }
}

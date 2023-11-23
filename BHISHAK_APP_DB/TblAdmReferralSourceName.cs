using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblAdmReferralSourceName
    {
        public int ReferralSourceNameId { get; set; }
        public string ReferralSourceName { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public int ReferralSourceId { get; set; }
        public int StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual TblAdmReferralSource ReferralSource { get; set; }
        public virtual TblAdmStatus Status { get; set; }
    }
}

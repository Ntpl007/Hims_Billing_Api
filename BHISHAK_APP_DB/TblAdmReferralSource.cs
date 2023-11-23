using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblAdmReferralSource
    {
        public TblAdmReferralSource()
        {
            TblAdmReferralSourceNames = new HashSet<TblAdmReferralSourceName>();
        }

        public int ReferralSourceId { get; set; }
        public string ReferralSourceCode { get; set; }
        public string ReferralSourceDesc { get; set; }
        public int StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual TblAdmStatus Status { get; set; }
        public virtual ICollection<TblAdmReferralSourceName> TblAdmReferralSourceNames { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hims_Billing_API.ViewModel
{
    public class BillingSearchInput
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string MobileNumber { get; set; } = null;
        public string FirstName { get; set; } = null;
        public int OrganizationId { get; set; }
        public int FacilityId { get; set; }
    }
}

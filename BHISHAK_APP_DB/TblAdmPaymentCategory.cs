using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblAdmPaymentCategory
    {
        public TblAdmPaymentCategory()
        {
            TblEncounterBillingEntries = new HashSet<TblEncounterBillingEntry>();
        }

        public int PaymentCategoryId { get; set; }
        public string PaymentCategory { get; set; }
        public int? StatusId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual ICollection<TblEncounterBillingEntry> TblEncounterBillingEntries { get; set; }
    }
}

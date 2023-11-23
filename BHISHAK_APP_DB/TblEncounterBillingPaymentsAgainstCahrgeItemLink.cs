using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblEncounterBillingPaymentsAgainstCahrgeItemLink
    {
        public string PaymentBillingEntryId { get; set; }
        public string PaymentAgainstBillingEntryId { get; set; }
        public int ChargeItemId { get; set; }
        public long EncounterId { get; set; }
        public decimal? PaidAmount { get; set; }
    }
}

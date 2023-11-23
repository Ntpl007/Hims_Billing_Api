using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblRegistrationBilling
    {
        public int RegId { get; set; }
        public long? PatientId { get; set; }
        public string PatientMrn { get; set; }
        public decimal? RegistrationAmount { get; set; }
        public decimal? PaidAmount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string ReceiptNumber { get; set; }
        public int? OrganigationId { get; set; }
        public int? FecilityId { get; set; }
        public int? PaymentModeId { get; set; }
    }
}

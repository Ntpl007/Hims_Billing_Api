using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblEncounterBillingPayment
    {
        public int BillingId { get; set; }
        public int? FinalBillingId { get; set; }
        public long? EncounterId { get; set; }
        public long? PatientId { get; set; }
        public string PatientMrn { get; set; }
        public decimal? TotalBilledAmount { get; set; }
        public decimal? TotalDiscountAmount { get; set; }
        public decimal? TotalPaidAmount { get; set; }
        public decimal? TotalRefundAmount { get; set; }
        public decimal? TotalDue { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public int? PaymentModeId { get; set; }
        public string PaymentRefCode { get; set; }
        public int? OrganizationId { get; set; }
        public int? FacilityId { get; set; }
        public string RecieptNo { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblEncounterBillingEntry
    {
        public string EncounterEntryId { get; set; }
        public long EncounterId { get; set; }
        public long? PatientId { get; set; }
        public int ChargeItemId { get; set; }
        public DateTime? DateOfService { get; set; }
        public int? ProviderId { get; set; }
        public decimal UnitPrice { get; set; }
        public float NoOfUnits { get; set; }
        public decimal? ChargeAmount { get; set; }
        public decimal? PaymentAmount { get; set; }
        public int? PaymentModeId { get; set; }
        public string PaymentRefCode { get; set; }
        public string ChequeNo { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? EncounterOrderId { get; set; }
        public int? FacilityId { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public int? RegisterId { get; set; }
        public decimal? ReferringPhysicianCommissionAmount { get; set; }
        public decimal? ProviderCommissionAmount { get; set; }
        public int? ReferringPhysicianId { get; set; }
        public long? BillNo { get; set; }
        public decimal? PaidAmount { get; set; }
        public decimal? Discount { get; set; }
        public int? ChargeGroupId { get; set; }
        public int? SequenceNumber { get; set; }
        public decimal? DueAmount { get; set; }
        public bool? IsChargeItemDeleted { get; set; }
        public string RefundAgainstBillingEntryId { get; set; }
        public bool? IsRefundAuthorised { get; set; }
        public int? PaymentCategoryId { get; set; }
        public decimal? PricePercentage { get; set; }

        public virtual TblAdmPaymentCategory PaymentCategory { get; set; }
    }
}

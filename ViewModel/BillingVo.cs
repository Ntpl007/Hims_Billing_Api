using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hims_Billing_API.ViewModel
{
    public class BillingVo
    {
        public string PatientId { get; set; }
        public string PatientMrn { get; set; }
        public string EncounterId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalDiscAmount { get; set; }
        public decimal TotalPaidAmount { get; set; }
        public decimal TotalRefundAmount { get; set; }
        public decimal TotalDueAmount { get; set; }
        public decimal TotalDiscPerc { get; set; }
        public string PaymentMode { get; set; }

        public string RefNo { get; set; }
        public string BillId { get; set; }
        public int OrganizationId { get; set; }
        public int FacilityId { get; set; }
        public string CreatedBy { get; set; }
        //public DateTime CreatedDate { get; set; }
        public List<BillingDetailsVo> BillingDetails { get; set; }
    }
}

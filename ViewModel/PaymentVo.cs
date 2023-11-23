using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hims_Billing_API.ViewModel
{
    public class PaymentVo
    {
        public string Comments { get; set; } = null;
        public long? encounterId { get; set; } = null;
        public string createdBy { get; set; } = null;
        public int? PaymentModeId { get; set; } = null;
        public decimal? PaymentAmount { get; set; } = null;
        public long? PatienTId { get; set; } = null;
        public int? RefDoctorId { get; set; } = null;
        public int? DoctorId { get; set; } = null;
        public int PaymentCategoryId { get; set; }
        public decimal ChargeAmount { get; set; }
        public string ReferenceNo { get; set; } = null;
    }
}

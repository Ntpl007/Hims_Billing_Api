using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hims_Billing_API.ViewModel
{
    public class BillingPriceDetailsVo
    {
        public decimal BilledAmount { get; set; }
        public decimal TotalDiscountAmount { get; set; }
        public decimal TotalPaidAmount { get; set; }
        public decimal TotalRefundAmount { get; set; }
        public decimal TotalDue { get; set; }
        public int PaymentModeId { get; set; }
    }
}

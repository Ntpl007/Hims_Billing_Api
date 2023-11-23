using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hims_Billing_API.ViewModel
{
    public class BillSummaryDetailsVo
    {
        public int BillId { get; set; }

        public int FinalBillId { get; set; }

        public decimal TotalBillAmt { get; set; }
        public decimal TotalDiscAmt { get; set; }
        public decimal TotalPaidAmt { get; set; }
        public decimal TotalRefundAmt { get; set; }
        public decimal TotalDue { get; set; }
    }
}

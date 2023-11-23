using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblAdmPaymentMode
    {
        public int PaymentModeId { get; set; }
        public string PaymentMode { get; set; }
        public bool? Collectable { get; set; }
        public string Notes { get; set; }
        public int? StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}

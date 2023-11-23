using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hims_Billing_API.ViewModel
{
    public class BillingDetailsVo
    {
        public string EncounterId { get; set; }
        public string PatientId { get; set; }
        public int   ChargeItemId { get; set; }
        public string ShortName { get; set; }
        //public DateTime DateOfService { get; set; }
        public int? ProviderId { get; set; }
        public decimal UnitPrice { get; set; }
        public int NoOfUnits { get; set; }
        //public decimal ChargeAmount { get; set; }
        //public decimal PaymentAmount { get; set; }
        //public int PaymentModeId { get; set; }
        //public decimal DiscountPerc { get; set; }
        public int? ReferingPhysicianId { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal PayingAmount { get; set; }
        public decimal DiscountPerc { get; set; }
        public decimal DueAmount { get; set; }
        public decimal AmountPerc { get; set; }
        public int PaymentMode { get; set; }
        //public string CreatedBy { get; set; }
        //public DateTime CreatedDate { get; set; }


    }
}

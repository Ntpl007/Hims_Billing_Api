using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hims_Billing_API.ViewModel
{
    public class ChargeItemVo
    {
        public int ChargeItemId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public decimal UnitPrice { get; set; }

        
        public int ChargeGroupId { get; set; }
        public string ChargeGroup { get; set; }
    }
}

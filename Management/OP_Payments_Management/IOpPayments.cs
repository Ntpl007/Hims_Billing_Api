using Hims_Billing_API.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hims_Billing_API.Management.OP_Payments_Management
{
    interface IOpPayments
    {
        public void SavePayments(PaymentVo[] objpatinput);
    }
}

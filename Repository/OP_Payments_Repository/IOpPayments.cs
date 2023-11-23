using Hims_Billing_API.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hims_Billing_API.Repository.OP_Payments_Repository
{
    interface IOpPayments
    {
        public void SavePayments(PaymentVo[] objpatinput);
    }
}

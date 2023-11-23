using Hims_Billing_API.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hims_Billing_API.Repository.OP_Payments_Repository;

namespace Hims_Billing_API.Management.OP_Payments_Management
{
    public class OpPayments : IOpPayments
    {
        public void SavePayments(PaymentVo[] objpatinput)
        {
            Op_Payments obj = new Op_Payments();
            obj.SavePayments(objpatinput);
        }
    }
}

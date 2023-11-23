using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblAdmPatientBillType
    {
        public int BillTypeId { get; set; }
        public string BillType { get; set; }
        public int? StatusId { get; set; }
        public string CreatedBy { get; set; }
    }
}

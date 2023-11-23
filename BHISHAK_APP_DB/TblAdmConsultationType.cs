using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblAdmConsultationType
    {
        public int ConsultationTypeId { get; set; }
        public string ConsultationType { get; set; }
        public int? StatusId { get; set; }

        public virtual TblAdmStatus Status { get; set; }
    }
}

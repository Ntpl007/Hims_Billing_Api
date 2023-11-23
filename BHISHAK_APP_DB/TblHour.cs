using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblHour
    {
        public int Id { get; set; }
        public string Hours { get; set; }
        public int? Htype { get; set; }
    }
}

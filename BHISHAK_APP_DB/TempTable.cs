using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TempTable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int? Count { get; set; }
        public int? DoctorId { get; set; }
    }
}

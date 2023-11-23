using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblTime
    {
        public int Id { get; set; }
        public int? H { get; set; }
        public int? M { get; set; }
        public string _5mins { get; set; }
        public string _10mins { get; set; }
        public string _15mins { get; set; }
        public string _20mins { get; set; }
        public string _25mins { get; set; }
        public string _30mins { get; set; }
    }
}

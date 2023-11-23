using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblFacilityDoctorTariff
    {
        public int DoctorTariffId { get; set; }
        public int? DoctorId { get; set; }
        public int? ChargeItemId { get; set; }
        public int? OraganisationId { get; set; }
        public int? FacilityId { get; set; }
        public decimal? BasePrice { get; set; }
        public decimal? OverridenPrice { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblFacilityTariffMaster
    {
        public int FacilityTariffId { get; set; }
        public int? ChargeItemId { get; set; }
        public string DisplayName { get; set; }
        public int? OraganisationId { get; set; }
        public int? FacilityId { get; set; }
        public decimal? BasePrice { get; set; }
        public decimal? UnitPrice { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblFacilityVitalsign
    {
        public int FacilityVitalsignId { get; set; }
        public int VitalsignId { get; set; }
        public int FacilitySpecialitylnkId { get; set; }
        public int StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? OrderNumber { get; set; }
    }
}

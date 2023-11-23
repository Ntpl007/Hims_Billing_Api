using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblFacilityMapping
    {
        public TblFacilityMapping()
        {
            TblFacilitySpecialityLnks = new HashSet<TblFacilitySpecialityLnk>();
        }

        public int FacilityMappingId { get; set; }
        public int? FacilityId { get; set; }
        public int? OrganizationId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Createdby { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Modifiedby { get; set; }
        public string Address { get; set; }

        public virtual ICollection<TblFacilitySpecialityLnk> TblFacilitySpecialityLnks { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblAdmFacilityType
    {
        public TblAdmFacilityType()
        {
            TblFacilities = new HashSet<TblFacility>();
            TblProviders = new HashSet<TblProvider>();
        }

        public int FacilityTypeId { get; set; }
        public string FacilityType { get; set; }
        public string FacilityTypeDescription { get; set; }
        public int StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual TblAdmStatus Status { get; set; }
        public virtual ICollection<TblFacility> TblFacilities { get; set; }
        public virtual ICollection<TblProvider> TblProviders { get; set; }
    }
}

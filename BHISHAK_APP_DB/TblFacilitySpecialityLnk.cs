using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblFacilitySpecialityLnk
    {
        public int FacilitySpecialitlnkId { get; set; }
        public int FacilityMappingId { get; set; }
        public int SpecialityId { get; set; }
        public int StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual TblFacilityMapping FacilityMapping { get; set; }
        public virtual TblAdmSpeciality Speciality { get; set; }
        public virtual TblAdmStatus Status { get; set; }
    }
}

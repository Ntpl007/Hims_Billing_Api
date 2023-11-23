using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblAdmSpeciality
    {
        public TblAdmSpeciality()
        {
            TblFacilities = new HashSet<TblFacility>();
            TblFacilitySpecialityLnks = new HashSet<TblFacilitySpecialityLnk>();
            TblProviders = new HashSet<TblProvider>();
        }

        public int SpecialityId { get; set; }
        public string Speciality { get; set; }
        public string SpecialityDesc { get; set; }
        public int StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual TblAdmStatus Status { get; set; }
        public virtual ICollection<TblFacility> TblFacilities { get; set; }
        public virtual ICollection<TblFacilitySpecialityLnk> TblFacilitySpecialityLnks { get; set; }
        public virtual ICollection<TblProvider> TblProviders { get; set; }
    }
}

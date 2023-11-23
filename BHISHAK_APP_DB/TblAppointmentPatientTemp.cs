using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblAppointmentPatientTemp
    {
        public TblAppointmentPatientTemp()
        {
            TblAppointments = new HashSet<TblAppointment>();
        }

        public int PatientTempId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal? Age { get; set; }
        public int? Sex { get; set; }
        public int? AgeMode { get; set; }
        public string MobileNumber { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string AadharNo { get; set; }
        public int? StateId { get; set; }
        public int? DistrictId { get; set; }
        public string City { get; set; }
        public string DoorNo { get; set; }
        public string Village { get; set; }
        public string Prefix { get; set; }
        public int? NationalityId { get; set; }
        public int? ReligionId { get; set; }
        public string Pincode { get; set; }
        public int? OrganizationId { get; set; }
        public string Email { get; set; }

        public virtual TblAdmDistrict District { get; set; }
        public virtual TblAdmNationality Nationality { get; set; }
        public virtual TblOrganization Organization { get; set; }
        public virtual TblAdmReligion Religion { get; set; }
        public virtual TblAdmState State { get; set; }
        public virtual ICollection<TblAppointment> TblAppointments { get; set; }
    }
}

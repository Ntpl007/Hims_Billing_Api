using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public long? MobileNumber { get; set; }
        public string Password { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string EncryptedPassword { get; set; }
        public string EncryptedKey { get; set; }
        public string EncryptedIv { get; set; }
        public int? FacilityId { get; set; }
        public int? OrganizationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? IsProvider { get; set; }
        public int? SpecialityId { get; set; }
        public bool? Status { get; set; }
        public bool? IsReferDoctor { get; set; }
        public int? RoleId { get; set; }
        public string ListName { get; set; }
        public string FacilityList { get; set; }
    }
}

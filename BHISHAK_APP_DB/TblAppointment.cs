using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblAppointment
    {
        public int PatientAppointmentId { get; set; }
        public int? ScheduleId { get; set; }
        public int? PatientTempId { get; set; }
        public long? PatientId { get; set; }
        public int FacilityId { get; set; }
        public int OrganizationId { get; set; }
        public int? DoctorId { get; set; }
        public int? ReferringPhysicianId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int ScheduleTypeId { get; set; }
        public int? AppointmentStatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? SpecialityId { get; set; }
        public int? AppointmentStatus { get; set; }
        public DateTime? CloseDateTime { get; set; }
        public int? ChargeGroupId { get; set; }
        public int? ChargeItemId { get; set; }
        public string EmailStatus { get; set; }
        public int? Smsstatus { get; set; }

        public virtual TblAdmFacility Facility { get; set; }
        public virtual TblOrganization Organization { get; set; }
        public virtual TblAppointmentPatientTemp PatientTemp { get; set; }
        public virtual TblScheduleType ScheduleType { get; set; }
    }
}

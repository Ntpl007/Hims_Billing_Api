using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblOrganization
    {
        public TblOrganization()
        {
            TblAppointmentPatientTemps = new HashSet<TblAppointmentPatientTemp>();
            TblAppointments = new HashSet<TblAppointment>();
        }

        public int OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Createdby { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Modifiedby { get; set; }
        public string Address { get; set; }

        public virtual ICollection<TblAppointmentPatientTemp> TblAppointmentPatientTemps { get; set; }
        public virtual ICollection<TblAppointment> TblAppointments { get; set; }
    }
}

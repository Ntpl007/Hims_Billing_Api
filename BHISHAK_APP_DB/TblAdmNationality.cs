using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblAdmNationality
    {
        public TblAdmNationality()
        {
            TblAppointmentPatientTemps = new HashSet<TblAppointmentPatientTemp>();
            TblPatients = new HashSet<TblPatient>();
        }

        public int NationalityId { get; set; }
        public string NationalityName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }

        public virtual ICollection<TblAppointmentPatientTemp> TblAppointmentPatientTemps { get; set; }
        public virtual ICollection<TblPatient> TblPatients { get; set; }
    }
}

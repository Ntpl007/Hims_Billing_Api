using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblAdmDistrict
    {
        public TblAdmDistrict()
        {
            TblAppointmentPatientTemps = new HashSet<TblAppointmentPatientTemp>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? StateId { get; set; }
        public string Createdby { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Updatedby { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<TblAppointmentPatientTemp> TblAppointmentPatientTemps { get; set; }
    }
}

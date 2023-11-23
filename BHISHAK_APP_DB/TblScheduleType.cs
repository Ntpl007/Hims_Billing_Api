using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblScheduleType
    {
        public TblScheduleType()
        {
            TblAppointments = new HashSet<TblAppointment>();
        }

        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int ScheduleTypeId { get; set; }
        public string ScheduleTypeName { get; set; }

        public virtual ICollection<TblAppointment> TblAppointments { get; set; }
    }
}

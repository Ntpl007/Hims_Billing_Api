using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblAdmScheduleSlotsStatus
    {
        public TblAdmScheduleSlotsStatus()
        {
            TblProviderScheduleTemplatePeriods = new HashSet<TblProviderScheduleTemplatePeriod>();
            TblProviderSchedules = new HashSet<TblProviderSchedule>();
        }

        public int ScheduleSlotStatusId { get; set; }
        public string ScheduleSlotStatusName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<TblProviderScheduleTemplatePeriod> TblProviderScheduleTemplatePeriods { get; set; }
        public virtual ICollection<TblProviderSchedule> TblProviderSchedules { get; set; }
    }
}

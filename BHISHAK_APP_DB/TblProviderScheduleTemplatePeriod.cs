using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblProviderScheduleTemplatePeriod
    {
        public TblProviderScheduleTemplatePeriod()
        {
            TblProviderSchedules = new HashSet<TblProviderSchedule>();
        }

        public long ScheduleTemplatePeriodId { get; set; }
        public int ScheduleTemplateId { get; set; }
        public DateTime? PeriodStart { get; set; }
        public DateTime? PeriodEnd { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte? IsMonday { get; set; }
        public byte? IsTuesday { get; set; }
        public byte? IsWednesday { get; set; }
        public byte? IsThursday { get; set; }
        public byte? IsFriday { get; set; }
        public byte? IsSaturday { get; set; }
        public byte? IsSunday { get; set; }
        public int? StatusId { get; set; }
        public int? ScheduleSlotStatusId { get; set; }

        public virtual TblAdmScheduleSlotsStatus ScheduleSlotStatus { get; set; }
        public virtual TblProviderScheduleTemplate ScheduleTemplate { get; set; }
        public virtual ICollection<TblProviderSchedule> TblProviderSchedules { get; set; }
    }
}

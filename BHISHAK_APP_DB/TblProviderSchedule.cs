using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblProviderSchedule
    {
        public long ProviderScheduleId { get; set; }
        public int? ProviderId { get; set; }
        public int? ScheduleTemplateId { get; set; }
        public int? PeriodType { get; set; }
        public DateTime? PeriodStart { get; set; }
        public DateTime? PeriodEnd { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? StatusId { get; set; }
        public long? ScheduleTemplatePeriodId { get; set; }
        public int? ScheduleSlotStatusId { get; set; }
        public string DayOfWeek { get; set; }

        public virtual TblAdmScheduleSlotsStatus ScheduleSlotStatus { get; set; }
        public virtual TblProviderScheduleTemplate ScheduleTemplate { get; set; }
        public virtual TblProviderScheduleTemplatePeriod ScheduleTemplatePeriod { get; set; }
    }
}

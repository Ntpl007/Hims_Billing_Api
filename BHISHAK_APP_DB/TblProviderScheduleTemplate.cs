using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblProviderScheduleTemplate
    {
        public TblProviderScheduleTemplate()
        {
            TblProviderScheduleTemplatePeriods = new HashSet<TblProviderScheduleTemplatePeriod>();
            TblProviderSchedules = new HashSet<TblProviderSchedule>();
        }

        public int ScheduleTemplateId { get; set; }
        public string ScheduleTempalteName { get; set; }
        public int? ProviderId { get; set; }
        public int? FacilityId { get; set; }
        public int? ScheduleIntravel { get; set; }
        public DateTime? ScheduleStartTime { get; set; }
        public DateTime? ScheduleEndTime { get; set; }
        public int? StatusId { get; set; }
        public DateTime? ScheduleTemplateEffectiveDate { get; set; }
        public DateTime? ScheduleTempateExpirationDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual TblAdmFacility Facility { get; set; }
        public virtual ICollection<TblProviderScheduleTemplatePeriod> TblProviderScheduleTemplatePeriods { get; set; }
        public virtual ICollection<TblProviderSchedule> TblProviderSchedules { get; set; }
    }
}

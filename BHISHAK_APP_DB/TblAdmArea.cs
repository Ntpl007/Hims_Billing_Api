using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblAdmArea
    {
        public TblAdmArea()
        {
            TblPatients = new HashSet<TblPatient>();
        }

        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public decimal? MaxDiscountAmount { get; set; }
        public int? StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual TblAdmStatus Status { get; set; }
        public virtual ICollection<TblPatient> TblPatients { get; set; }
    }
}

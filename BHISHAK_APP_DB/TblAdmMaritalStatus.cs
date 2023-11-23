using System;
using System.Collections.Generic;

#nullable disable

namespace Hims_Billing_API.BHISHAK_APP_DB
{
    public partial class TblAdmMaritalStatus
    {
        public TblAdmMaritalStatus()
        {
            TblPatients = new HashSet<TblPatient>();
        }

        public int MaritalStatusId { get; set; }
        public string MaritalStatusCode { get; set; }
        public string MaritalStatusDesc { get; set; }
        public int StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual TblAdmStatus Status { get; set; }
        public virtual ICollection<TblPatient> TblPatients { get; set; }
    }
}

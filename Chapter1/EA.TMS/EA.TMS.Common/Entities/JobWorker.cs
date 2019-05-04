using EA.TMS.Common.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EA.TMS.Common.Entities
{
    [Description("To store Worker who will be assigned for Job")]
    [Table("JobWorker")]
    public class JobWorker : BaseEntity
    {
        [Key]
        public long Id { get; set; }

        public long JobId { get; set; }

        [ForeignKey("JobId")]
        public virtual Job Job { get; set; }

        public long EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }


    }
}

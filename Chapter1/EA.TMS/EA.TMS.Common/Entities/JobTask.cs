﻿using EA.TMS.Common.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EA.TMS.Common.Entities
{
    [Description("To store Tasks related to particular Job")]
    [Table("JobTask")]
    public class JobTask : BaseEntity
    {
        [Key]
        public long Id { get; set; }

        public long JobId { get; set; }

        [ForeignKey("JobId")]
        public virtual Job Job { get; set; }

        [MaxLength(500)]
        public string TaskDescription { get; set; }

    }
}

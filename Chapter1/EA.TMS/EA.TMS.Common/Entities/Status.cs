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
    [Description("To store Status")]
    [Table("Status")]
    public class Status : BaseEntity
    {

        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}

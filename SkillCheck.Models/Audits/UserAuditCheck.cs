﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Master;

namespace SkillCheck.Models.Audits
{
    public class UserAuditCheck
    {
        public Guid UserAuditCheckId { get; set; }
        public bool IsUpdated { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public AuditCheck AuditCheck { get; set; }
        public Proficiency Proficiency { get; set; }
    }
}
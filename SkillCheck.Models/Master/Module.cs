﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master
{
    public class Module
    {
        public Module()
        {
            Units = new List<Unit>();
        }
        
        public long ModuleId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public IEnumerable<Unit> Units { get; set; }
    }
}
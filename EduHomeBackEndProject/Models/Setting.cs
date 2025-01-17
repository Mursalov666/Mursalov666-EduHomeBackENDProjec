﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EduHomeProject.Models
{
    public class Setting : BaseEntity
    {
        public int Id { get; set; }
        [StringLength(2500)]
        public string Key { get; set; }
        [StringLength(2500)]
        public string Value { get; set; }
    }
}

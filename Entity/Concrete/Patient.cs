﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        public int UserId { get; set; }
        public string PatientName { get; set; }

    }
}

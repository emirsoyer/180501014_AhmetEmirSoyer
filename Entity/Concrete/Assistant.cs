﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Assistant
    {
        [Key]
        public int AssistantId { get; set; }
        public int UserId { get; set; }
        public string AssitantName { get; set; }
    }
}

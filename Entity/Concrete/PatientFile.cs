using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class PatientFile
    {
        [Key]
        public int FileId { get; set; }
        public int PatientId { get; set; }
        public string FileDescription { get; set; }
        public string FileType { get; set; }
        public Patient Patient { get; set; }

    }
}

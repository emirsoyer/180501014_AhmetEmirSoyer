using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Prescription
    {
        [Key]
        public int PrescriptionId { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public string PrescriptionType { get; set; }
        public string PrescriptionDescription { get; set; }
    }
}

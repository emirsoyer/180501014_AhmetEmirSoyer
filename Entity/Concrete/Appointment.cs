using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        public string AppointmentDescription { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
    }
}

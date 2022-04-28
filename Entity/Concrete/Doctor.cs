using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        public int UserId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorTitle { get; set; }
        public User User { get; set; }
        public List<Prescription> Prescriptions { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public int TCNumber { get; set; }
        public string UserName { get; set; }
        public string UserType { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public List<Doctor> Doctors { get; set; }
        public List<Assistant> Assistants { get; set; }
        public List<Patient> Patients { get; set; }

    }
}

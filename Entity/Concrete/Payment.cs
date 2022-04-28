using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public string PaymentType { get; set; }
        public double PaymentAmount { get; set; }
        public int PatientId { get; set; }
        public DateTime PaymentDate { get; set; }
        public Patient Patient { get; set; }
    }
}

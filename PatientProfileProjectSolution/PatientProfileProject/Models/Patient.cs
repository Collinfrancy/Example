using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientProfileProject.Models
{
    public class Patient
    {
        public string PatientName { get; set; }
        public string PatientId { get; set; }
        public DateTime DOB { get; set; }
        public string Sex { get; set; }
        public string Place { get; set; }
        public DateTime ScheduleDate { get; set; }
    }
}

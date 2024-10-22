using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientProfileProject.ViewModels;

namespace PatientProfileProject
{
    static  class FormConfig
    {
        public static PatientViewModel patientViewModel { get; set; }

        static FormConfig() { 
        
        patientViewModel = new PatientViewModel();
        
        }

    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1Project
{





    public class JobTitle
    {
        public string Title { get; set; }
        public double Salary { get; set; }

        public string Display { get => $"{Title} @ {Salary}"; }
    }



}

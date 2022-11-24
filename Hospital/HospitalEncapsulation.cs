using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Hospital.HospitalPolymerphism;
namespace Hospital
{
    class HospitalEncapsulation
    {
        private String patienttName;
        private int patientAge;

        public String Name     //Name is property
        {

            get
            {
                return patienttName;
            }

            set
            {
                patienttName = value;
            }

        }
        public int Age
        {

            get
            {
                return patientAge;
            }

            set
            {
                patientAge = value;
            }

        }
    }
}

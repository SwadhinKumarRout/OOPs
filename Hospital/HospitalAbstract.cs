using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    // Abstract class
    abstract class HospitalName
    {
        // Abstract method (does not have a body)
        public abstract void HosName();
        // Regular method
        public void HospitalId()
        {
            Console.WriteLine("111");
        }
    }

    // Derived class (inherit from HospitalName )
    class HospitalDetail : HospitalName
    {
        public override void HosName()
        {
            // The body of HosName() is provided here
            Console.WriteLine("Hospital name is AIIMS");
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class HospitalPolymerphism
    {
        public virtual void Hospital()
        {
            Console.WriteLine("This is a good hospital");
        }
    }
    class HospitalReview : HospitalPolymerphism
    {
        public override void Hospital()
        {
            Console.WriteLine("4 out of 5");
        }
    }
    class HospitalCharges : HospitalPolymerphism
    {
        public override void Hospital()
        {
            Console.WriteLine("Charges are very high");
        }
    }
}

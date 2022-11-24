using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class HospitalInheritance
    {

        string name = "AIIMS";

        class Hospital2Inheritance : HospitalInheritance
        {
            string address = "Bhubaneswar";


            static void Main(string[] args)
            {

                Hospital2Inheritance hi = new Hospital2Inheritance();
                  

                Console.WriteLine(hi.name);
                Console.WriteLine(hi.address);
                Console.ReadLine();

                HospitalDetail hospitalDetail = new HospitalDetail();  // Create a HospitalDetail object
                hospitalDetail.HosName();
                hospitalDetail.HospitalId();
                Console.ReadLine();

                HospitalPolymerphism hospitalPolymerphis = new HospitalPolymerphism();
                HospitalPolymerphism hospitalReview = new HospitalReview();
                HospitalPolymerphism hospitalCharges = new HospitalCharges();
                hospitalPolymerphis.Hospital();
                hospitalReview.Hospital();
                hospitalCharges.Hospital();

                Console.ReadLine();


                HospitalMethodOverload hospitalMethodOverload = new HospitalMethodOverload();
                hospitalMethodOverload.HospitalData("swadhin");
                hospitalMethodOverload.HospitalData("swadhin", 1);
                Console.ReadLine();


                HospitalEncapsulation hospitalEncapsulatio = new HospitalEncapsulation();
                hospitalEncapsulatio.Name = "swadhin";
                hospitalEncapsulatio.Age = 27;
                Console.WriteLine("Name: " + hospitalEncapsulatio.Name);
                Console.WriteLine("Age: " + hospitalEncapsulatio.Age);
                Console.ReadLine();
            }
        }
    }
}


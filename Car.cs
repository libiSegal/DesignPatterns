using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    internal class Car
    {
        public double FualCapacity { get; set; }
        public string Company { get; set; }
        public int NumOfSits { get; set; }
        public string LicensPlate { get; set; }
        public bool Convertible { get; set; }
        

        public Car(double fualCapacity, string company, int numOfSits, string licensPlate, bool convertible)
        {
            FualCapacity = fualCapacity;
            Company = company;
            NumOfSits = numOfSits;
            LicensPlate = licensPlate;
            Convertible = convertible;
        }
        public override string ToString() => $"  ";

         
    }
}

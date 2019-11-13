using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw5
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Bicycle bicycle1 = new Bicycle();
            car1.Ride();
            bicycle1.Ride();
            
            Osoba osoba1 = new Osoba();
            osoba1.Graj();
            IGitarzysta franek = new Osoba();
            ISkrzypek stasiu = new Osoba();
            franek.Graj();
            stasiu.Graj();
            Console.ReadKey();
        }
    }
}

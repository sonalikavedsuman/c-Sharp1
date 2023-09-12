using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Details();
            Car audi = new Car("Audi A4", 350 ,"Blue");
            audi.Drive();
            audi.Details();
            Car bmw = new Car("BMW M5", 450);
            bmw.Drive();
            bmw.Details();
            Console.WriteLine("Press 1 to stop the car");
            string userInput = Console.ReadLine();
            if(userInput == "1")
            {
                audi.Stop();
            }
            else
            {
                Console.WriteLine("Car drives indefinitely");
            }
            
            Console.Read();

        }
    }
}

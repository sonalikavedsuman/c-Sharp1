using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassesAndObjects
{
    internal class Car
    {
        //Member Variables
        //Access Modifier --> private
        //private string _name;
        private string _name;
        private int _hp;
        private string _color;
        
        // Default Constructor

        public Car()
        {
            _name = "Car";
            _hp = 0;
            _color = "Red";
        }

        //Partial Specification Constructor
        public Car(string name, int hp = 0)
        {
            _name = name;
            Console.WriteLine(name + " was created");
            _hp = hp;
            _color = "red";

        }

        //Full Specification Constructor
        public Car(string name, int hp, string color)
        {
            _name = name;
            Console.WriteLine(name + " was created");
            _hp = hp;
            _color = color;

        }

        //Constructor
        //public Car(string name, int hp = 0 , string color = "Black") 
        //{
        //    _name = name;
        //    Console.WriteLine(name + " was created");
        //    _hp = hp;
        //    _color = color;

        //}

        //Member Method
        public void Drive() 
        {
            Console.WriteLine(_name + " is Driving");
        }
        public void Stop() 
        {
            Console.WriteLine(_name + " Stopped");
        }
        public void Details()
        {
            Console.WriteLine("My Car name is " + _name + " " +_color + " Color and It has horse power of " + _hp);
        }
    }
}

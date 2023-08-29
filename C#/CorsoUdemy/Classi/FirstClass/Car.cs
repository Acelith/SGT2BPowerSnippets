using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    internal class Car
    {
        // istance variable (access modyfier set to privat = acces only inside the class)
        private string _brand;
        private string _type;
        private int _year;
        private int _hp;

        //setter are usually after the constructor
        //they are used to set values of a private instance variavle
        public void setName(string brand)
            // we can set condition on how the setter work
        {   // if the name is an empty string
            if (brand == "")
            {
                this._brand = "default name";
            }
            else
            {// if not empty you can change it
                this._brand = brand;
            }
        }

        // default constructor (empty without argument)
        public Car() 
        {
            Console.WriteLine("A new Car was created");
            // is a good practice (but not mandatory) to give some default value
            this._brand = "Unspecified car";
            this._type = "Unspecified type";
            this._year = 0;
            this._hp = 0;
        }

        // constructor (with argument & full specification)
        public Car(string brand, string type, int year, int hp = 0) //default value
        { 
            this._brand = brand;
            this._type = type;
            this._year = year;
            this._hp = hp;
            Console.WriteLine(brand + " " + type + " was created");
        }

        // constructor (with partial specification)
        public Car(string brand, string type)
        {
            this._brand = brand;
            this._type = type;
            Console.WriteLine(brand + " " + type + " was created");
        }

        // member method
        public void Drive() 
        { 
            Console.WriteLine(this._brand + " " + this._type + " is driving"); 
        }

        // member method
        public void Stop()
        {
            Console.WriteLine(this._brand + " " + this._type + " stopped");
        }

        // member method
        public void Details()
        {
            Console.WriteLine("The car is a " + this._brand + " " + this._type);
            if (this._year > 0)
            {
                Console.WriteLine("It was fabricated in " + this._year);
            }
            if (this._hp > 0)
            {
                Console.WriteLine("Has an engine that develop " + this._hp + " horse power");
            }
            
        }
    }
}

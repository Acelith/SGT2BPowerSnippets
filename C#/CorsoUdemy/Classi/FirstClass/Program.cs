using System.Security.Cryptography.X509Certificates;

namespace FirstClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instanziation of a new object
            Car honda = new Car("honda", "civic", 2004, 200);
            // whit F12 when a metod is higlight it direct on the metod!
            // CTRL + '-' return back & CTRL + shift + '-' go back again
            honda.Drive();
            honda.Details();

            Car bmw = new Car("bmw", "m3", 2023);
            bmw.Drive();
            bmw.Details();

            Car myCar = new Car();
            // useage of a setter for changing the default value of a private variable
            myCar.setName("Default care modified by setter");
            myCar.Details();

            Car myCar2 = new Car("toyota", "corolla");
            myCar2.Details();

            // testing the conditions of the setter
            Car myCar3 = new Car();
            myCar3.setName("");
            myCar3.Details();
            myCar3.setName("fiat");
            myCar3.Details();

            Console.Write("Would you like stop? ");
            string userInput = Console.ReadLine();
            if (userInput.Equals("yes"))
            {
                honda.Stop();
            }
            else
            {
                Console.WriteLine("Car keeps going");
            }
            Console.Read();
        }
    }
}
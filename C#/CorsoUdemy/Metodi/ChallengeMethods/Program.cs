using System.Xml.Linq;

namespace ChallengeMethods
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string name1 = "Luca";
            string name2 = "Matteo";
            string name3 = "Filippa";

            GreetName(name1);
            GreetName(name2);
            GreetName(name3);

            Console.WriteLine("------------------------");

            GreetAllName(name1, name2, name3);

            Console.Read();
        }
        public static void GreetName(string name)
        {
            Console.WriteLine("Hi " + name + ", my friend!");
        }
        public static void GreetAllName(string name1, string name2, string name3)
        {
            Console.WriteLine("Hi " + name1 + ", my friend!");
            Console.WriteLine("Hi " + name2 + ", my friend!");
            Console.WriteLine("Hi " + name3 + ", my friend!");
        }
    }
}
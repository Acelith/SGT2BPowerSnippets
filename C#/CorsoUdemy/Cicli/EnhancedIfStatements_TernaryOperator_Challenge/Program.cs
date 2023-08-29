using System.Threading.Channels;

namespace EnhancedIfStatements_TernaryOperator_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temp;
            int intTemp;

            Console.Write("Enter the temperature: ");
            temp = Console.ReadLine();

            string tempMessage = int.TryParse(temp, out intTemp) ? (intTemp <= 15 ? "it is too cold here" : (intTemp >= 16 && intTemp <= 28 ? "it is ok" : "it is hot here")) : "Not a valid Temperature";
            Console.Write(tempMessage);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("At 3 we stop!");
                    // it break the loop
                    break;
                }
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Now comes an odd number!");
                    // it skip the curent loop
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.Read();

        }
    }
}

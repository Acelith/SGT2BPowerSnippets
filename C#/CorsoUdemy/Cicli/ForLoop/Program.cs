using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 20; i += 2)
            {
                if (i < 19)
                {
                    Console.Write(i + ", ");
                }
                else
                {
                    Console.Write(i);
                }
            }
            Console.Read();
        }
    }
} 
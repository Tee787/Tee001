using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountIncrements
{
    class Program
    {
        static void Main(string[] args)
        {
            int finalCount = 0;
            int inCrement = 0;

            Console.Write("What number do you want me to count up to: ");

            finalCount = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("What increments do you want me to count in: ");

            inCrement = Int32.Parse(Console.ReadLine());

            int iterations = finalCount / inCrement;

            int nbr = 0;

            Console.WriteLine(nbr);

            for (int i = 1; i < iterations + 1; i++)
            {
                nbr += inCrement;
                Console.WriteLine(nbr);
            }

            Console.ReadLine();
        }
    }
}


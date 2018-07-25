// This is the code that we did in class regarding the "coin toss" of "heads" or "tails"
// Can change the number of times the coin has been tossed. Example: 1, 2, 3, etc
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   Random myRandomNumber = new Random();
               for (int i = 0; i < 30; i++)

                   Console.WriteLine(myRandomNumber.Next(0, 100));

               Console.ReadLine();

       */


            Console.WriteLine("Press enter key to toss the coin three times....");

            Console.ReadLine();

            Random randNbr = new Random();

            for (int i = 0; i < 3; i++)
            {
                int randomNbr = randNbr.Next(1, 10);

                if (randomNbr <= 5)
                {
                    Console.WriteLine("Tails");

                }
                else
                {
                    Console.WriteLine("Heads");
                }

            }

            Console.ReadLine();




        }
    }
}

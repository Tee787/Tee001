/* My Mteric Conversion Calculator for the Programming Assignment 
 The code in this console works on a "do while" loop back to the start when user inputs "Y"
 Console will close when user input is "N" */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using the "string" method and "double" precision floating point with my variables

            string CODE;
            string Output;
            double lbs, kgs, inc, cms;

            Boolean backToTop = true;

            do
            {
                Console.WriteLine("<----------METRIC CONVERSION CALCULATOR---------->\n");
                Console.WriteLine("Please choose from the conversion menu below:\n");
                Console.WriteLine("inches to centimeters\t" + "CODE: LENGTH\n");
                Console.WriteLine("pounds to kilograms\t" + "CODE: WEIGHT\n");
                Console.Write("\nENTER CODE: ");
                CODE = Console.ReadLine().ToUpper();

                if (CODE == "LENGTH")
                {
                    Output = "centimeters";
                    Console.WriteLine("\nEnter the length in inches: \n");
                    inc = double.Parse(Console.ReadLine());
                    cms = inc * 2.54;
                    Console.WriteLine("The length is: {0:N1} cms\n", cms);
                }

                else if (CODE == "WEIGHT")
                {
                    Output = "kilograms";
                    Console.WriteLine("\nEnter the weight in pounds: \n");
                    lbs = double.Parse(Console.ReadLine());
                    kgs = lbs / 2.2046;
                    Console.WriteLine("\nThe weight is: {0:N1}kgs\n", kgs);
                }

                Console.WriteLine("\nWould you like to enter another CODE? Y/N \n");
                var check = Console.ReadLine().ToUpper();
                if (check == "N")
                { backToTop = false; }
                Console.Clear();
                if (check == "Y")
                { backToTop = true; }

            } while (backToTop);




        }
    }
}

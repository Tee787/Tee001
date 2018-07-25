//------------------------------Calulator for, Radius, Diameter, Circuference and Area of a Circle------------------------------------
// Here is my calculator that I made using C# Console Application

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculator for Radius, Diameter, Circumference and Area of a circle.\n");    //This line defines what this application is about. Application Heading.

            double diameter, circumference, area;                                                       //Declaring the class type as a "double" floating precision point and variables to be used.

            Console.Write("\nEnter the radius: ");                                                      // Using the "Write" method so that we can input / type in the numeric value in the console display window.
            int radius = Convert.ToInt32(Console.ReadLine());                                           // Here is the conversion code needed to convert the integer of the radius to output the data for the reast of the variables
            Console.WriteLine("\nThe radius is: {0}cm ", radius);                                       // This output the "Radius" of the circle
            Console.WriteLine("\nThe diameter is: {0}cm ", 2 * radius);                                 // This will output the "Diameter"
            Console.WriteLine("\nThe circumference is: {0}cm ", Math.Round(2 * Math.PI * radius, 1));  // This will output the "Circumference"
            Console.WriteLine("\nThe area is: {0}cm ", Math.Round(Math.PI * (radius * radius), 1));    // Here is where the output of the "Area" of the circle will be dislpayed. (note: the "Math" fomulation for rounding to decimal place, and "Pie" of the circle)

            Console.ReadLine();                                                                         // The Readline is what will display the the output of the final result of the calculations.
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ResortPrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int total;
            string totalString;

            WriteLine ("How many nights would you like to stay");
            totalString = ReadLine();
            total = Convert.ToInt32(totalString);

            if (total >= 8)
                WriteLine("If you wish to stay for 8 or more nights that will be $145 a night ");
            if (total == 1 )
                WriteLine("If you wish to stay for 1 or 2 nights that will be $200 a night ");
            if (total == 2)
                WriteLine("If you wish to stay for 1 or 2 nights that will be $200 a night");
            if (total == 3)
                WriteLine("If you wish to stay for 3 or 4 nights that will be $180 a night");
            if (total == 4)
                WriteLine("If you wish to stay for 3 or 4 nights that will be $180 a night");
            if (total == 5)
                WriteLine("If you wish to stay for 5,6 or 7 nights that will be $160 a night");
            if (total == 6)
                WriteLine("If you wish to stay for 3 or 4 nights that will be $160 a night");
            if (total == 7)
                WriteLine("If you wish to stay for 3 or 4 nights that will be $160 a night");
            if (total >= 100)
                WriteLine("you absolute MAD LAD, also thank you for the money");

            WriteLine("you entered " + total + "so your total is " + (total + total));
        }
    }
}

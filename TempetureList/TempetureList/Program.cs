using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace TempetureList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temp = new int[7];
            int i;
            int number = 0;
            string numberString;
            int average;
            int total = 0;
            int j;
            do
            {
                WriteLine("enter temperature for this day");
                numberString = ReadLine();
                number = Convert.ToInt32(numberString);
                for (i = 0; i < temp.Length; i++)
                {
                    WriteLine("enter temperature for this day");
                    temp[i] = Convert.ToInt32(ReadLine());
                    total = temp[i] + total;
                }

                average = total / temp.Length;
                for (j = 0; j < temp.Length; j++)
                {
                   
                    WriteLine(" your average was " + average + " and you were " + (temp[j] - average) + 
                        " away "+ "from the average");
                }
                
            }
            while (number == 999);
        }   
        
    }
}

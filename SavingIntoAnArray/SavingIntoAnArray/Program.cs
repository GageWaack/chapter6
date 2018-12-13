using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace SavingIntoAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i;
            string entryString;
            int entry;

            do
            {
                Write("\n\nRead and Print elements of an array: \n");
                Write("------------------------------------------\n");
                Write("   Input 10 elements in the array also note that you can enter 999 to exit  ");
                entryString = ReadLine();
                entry = Convert.ToInt32(entryString);
                for (i = 1; i < 10; i++)
                {
                    Write("   enter a number -  " + i + " << ");
                    arr[i] = Convert.ToInt32(ReadLine());
                }
                Write("How do you want to see the previous input? 1, 2, or 3?");
                entryString = ReadLine();
                entry = Convert.ToInt32(entryString);
                if (entry == 1)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        WriteLine("Numbers entered were " + arr[j]);
                    }
                }
                if (entry == 2)
                {
                    Array.Reverse(arr);
                    for (int j = 0; j < arr.Length; ++j)
                    {
                        WriteLine("Numbers in reverse are  " + arr[j]);
                    }
                    if (entry == 3)
                    {
                        WriteLine("enter how you would like to see the numbers you entered");
                        entryString = ReadLine();
                        entry = Convert.ToInt32(entryString);
                    }
                    if (entry == 2)
                    {
                        Array.Reverse(arr);
                        for (int j = 0; j < arr.Length; ++j)

                            WriteLine("Numbers in reverse are  " + arr[j]);
                    }
                    if (entry == 1)
                    {
                        for (int j = 0; j < arr.Length; j++)
                        {
                            WriteLine("Numbers entered were " + arr[j]);

                        }
                    
                    }
                }
            } while (entry == 999);
            
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ScoresComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowScore;
            int[] arr = new int[4];
            int i;
            int total = 0;
            int highScore;
            int score = 0;
            string scoreString;

            for (i = 0; i < arr.Length; i++) 
            {
                WriteLine(" Enter your test scores ");
                arr[i] = Convert.ToInt32(ReadLine());
                scoreString = ReadLine();
                score = Convert.ToInt32(scoreString);
                total = arr[i] + total;
                if (score > total)
                    WriteLine(" your scores got lower, here is you failing ");
                lowScore = score;
            }
            
            Array.Reverse(arr);
            for (int j = 0; j < arr.Length; ++j)
            {
                WriteLine(" your scores in reverse are " + arr[j]);
                if (arr[i] < total)
                    WriteLine(" Nice! ");
                highScore = score;
            }
            if (arr[i] == 100)
                WriteLine (" Nice 100 percent! ");
            
        }
    }
}

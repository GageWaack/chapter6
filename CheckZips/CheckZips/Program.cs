using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            int area1 = 520;
            int area2 = 690;
            int area3 = 720;
            int area4 = 234;
            int area5 = 950;
            int area6 = 370;
            int area7 = 250;
            int area8 = 150;
            int area9 = 850;
            int area10 = 999;
            int zone;
            string zoneString;

            WriteLine ("Enter a zip code, also if you are not in our area you will not get a message back");
            zoneString = ReadLine();
            zone = Convert.ToInt32(zoneString);

            if (zone == area1)
                WriteLine (" this is in our delivery area :D ");
            if (zone == area2)
                WriteLine(" this is in our delivery area :D ");
            if (zone == area3)
                WriteLine(" this is in our delivery area :D ");
            if (zone == area4)
                WriteLine(" this is in our delivery area :D ");
            if (zone == area5)
                WriteLine(" this is in our delivery area :D ");
            if (zone == area6)
                WriteLine(" this is in our delivery area :D ");
            if (zone == area7)
                WriteLine(" this is in our delivery area :D ");
            if (zone == area8)
                WriteLine(" this is in our delivery area :D ");
            if (zone == area9)
                WriteLine(" this is in our delivery area :D ");
            if (zone == area10)
                WriteLine(" this is in our delivery area :D ");

            
        }

    }
}

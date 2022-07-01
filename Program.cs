using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week13_4
{
    class Program
    {
        enum WeekDays : int
        {
             SunDay = 17,MonDay = 11, TuesDay=12, WednesDay=13, ThursDay = 14, FriDay=15, SaturDay=16
        };
        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR__Week13_4");
            Console.WriteLine($"星期日={(int)WeekDays.SunDay}");
            Console.WriteLine($"星期一={(int)WeekDays.MonDay}");
            Console.WriteLine($"星期二={(int)WeekDays.TuesDay}");
            Console.WriteLine($"星期三={(int)WeekDays.WednesDay}");
            Console.WriteLine($"星期四={(int)WeekDays.ThursDay}");
            Console.WriteLine($"星期五={(int)WeekDays.FriDay}");
            Console.WriteLine($"星期六={(int)WeekDays.SaturDay}");
            int sum = 0;
            Console.WriteLine($"總數={(int)WeekDays.SunDay+ (int)WeekDays.MonDay+ (int)WeekDays.TuesDay+ (int)WeekDays.WednesDay+ (int)WeekDays.ThursDay+ (int)WeekDays.FriDay+ (int)WeekDays.SaturDay}");
            Console.ReadLine();
        }
    }
}

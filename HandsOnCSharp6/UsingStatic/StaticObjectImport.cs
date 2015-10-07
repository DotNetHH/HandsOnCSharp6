using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.DayOfWeek;

namespace HandsOnCSharp6.UsingStatic
{
    public class StaticObjectImport
    {
        public void LogProcess()
        {
            //In C# 5.0
            Console.WriteLine("Did some complex calculation");

            //In C# 6.0
            WriteLine("Did more complex calculation");
        }

        public DayOfWeek GetCoolDaysOfWeek()
        {
            //In C# 5.0
            var coolDays = DayOfWeek.Friday | DayOfWeek.Saturday | DayOfWeek.Sunday;

            //In C# 6.0
            coolDays = Friday | Saturday | Sunday;

            return coolDays;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCSharp6.ExceptionFilters
{
    public class ExceptionFilters
    {
        public void DoFunnyStuff()
        {
            for (int i = 0; i < 1002; i++)
            {
                try
                {
                    FunnyStuffHappensHere(i);
                } catch(ArgumentOutOfRangeException ex) when (i % 10 != 0)
                {
                    Console.WriteLine("a real exception happend", ex);
                }
            }
        }

        public void FunnyStuffHappensHere(int number)
        {

            if(number % 10 == 0)
                throw new ArgumentOutOfRangeException(nameof(number));

            if (number == 1001)
                throw new ArgumentOutOfRangeException(nameof(number));
        }
    }
}

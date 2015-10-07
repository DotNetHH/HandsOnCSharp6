using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using HandsOnCSharp6.Helper;

namespace HandsOnCSharp6.ExceptionFilters
{
    public class ExceptionFiltersMethodCall
    {
        private readonly Logger _logger = new Logger();

        public void DoFunnyStuff()
        {
            for (int i = 0; i < 1000; i++)
            {
                try
                {
                    FunnyStuffHappensHere(i);
                } catch(ArgumentOutOfRangeException ex) when (_logger.Log(ex)) { }
            }
        }

        public void FunnyStuffHappensHere(int number)
        {
            if(number % 10 == 0)
                throw new ArgumentOutOfRangeException(nameof(number));
        }
    }
}

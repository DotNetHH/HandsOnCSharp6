using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCSharp6.IndexInitializers
{
    public class IndexInitalizers
    {
        public IDictionary<int, string> GetSomeDictionary()
        {
            IDictionary<int, string> dict = null;

            //C# 5.0
            dict = new Dictionary<int, string>()
            {
                {1, "Value1"},
                {2, "Value2"}
            };

            //C# 6.0
            dict = new Dictionary<int, string>()
            {
                [1] = "Value1",
                [2] = "Value2"
            };

            return dict;

        }
    }
}

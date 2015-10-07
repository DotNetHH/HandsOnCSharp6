using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCSharp6.ExpressionBody
{
    public class MethodBody
    {
        private string _name = "Doe";
        private string _firstname = "John";

        //In C# 5.0
        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        //In C# 6.0
        public string GetFirstname() => _firstname;
        public void SetFirstname(string firstname) => _firstname = firstname;
    }
}

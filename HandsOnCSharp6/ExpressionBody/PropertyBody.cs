using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCSharp6.ExpressionBody
{
    public class PropertyBody
    {
        private string _name = "Doe";
        private string _firstname = "Jane";
        private int _id;

        //In C# 5.0 you need a full implemtation for the getter
        public string Fullname
        {
            get
            {
                return _name + " " + _firstname;
            }
        }

        //In C# 6.0 this is enough
        public string Fullname6 => _name + " " + _firstname;



        //Indexer C# 5.0
        public PropertyBody this[int id]
        {
            get
            {
                return new PropertyBody()
                {
                    _id = id
                };
            }
        }

        //Indexer C# 6.0
        public PropertyBody this[int id] => new PropertyBody() {_id = id};


    }
}

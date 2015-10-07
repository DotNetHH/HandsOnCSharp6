using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOnCSharp6.Helper;

namespace HandsOnCSharp6.NameOf
{
    public class NameOfExpression
    {
        public void SetCategoryForProduct(Product prodcut, Category? category)
        {
            if(category == null) throw new ArgumentNullException($"Arguemnt {nameof(category)} is null");
        }
    }
}

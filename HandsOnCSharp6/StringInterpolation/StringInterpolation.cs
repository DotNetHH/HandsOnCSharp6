using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOnCSharp6.Helper;

namespace HandsOnCSharp6.StringInterpolation
{
    public class StringInterpolation
    {
        private string _name = "Doe";
        private string _firstname = "Jane";

        public Product Product { get; } = new Product();

        public string GetBuyerOfProduct(Product product)
        {
            string result = null;

            //C# 5.0
            result = string.Format("{0} {1} bought {2}", _firstname, _name, product.Name);

            //C# 6.0
            result = $"{_firstname} {_name} bought {product?.Name}";

            return result;
        }

        public string GetMeasurementsOfProduct(Product product)
        {
            string result = null;

            //C# 5.0
            result = string.Format("{0} measurements: height: {1:D2}, width: {2:D2}, depth: {3:D2}", product.Name, product.Measurement.Heigth, product.Measurement.Width, product.Measurement.Depth);

            //C# 6.0
            result =
                $"{product?.Name} measurements: height: {product?.Measurement?.Heigth:D2}, width: {product?.Measurement.Width:D2}, depth: {product?.Measurement.Depth:D2}";

            return result;
        }

        public string GetStockOfProduct(Product product)
        {
            string result = null;

            //C# 5.0
            result = string.Format("There are {0} {1}{2} left", product.Stock, product.Name,
                product.Stock > 1 ? "s" : "");

            //C# 6.0
            result = $"There are {product?.Stock} {product?.Name}{(product?.Stock > 1 ? "s" : "")}";

            return result;
        }
    }
}

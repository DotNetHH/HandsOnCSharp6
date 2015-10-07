using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOnCSharp6.Helper;

namespace HandsOnCSharp6.NullConditional
{
    public class NullConditional
    {
        private ProductValut _vault = new ProductValut();

        public string GetProductName(Product product)
        {
            string name = null;
            
            //C# 5.0
            if (product != null)
            {
                name = product.Name;
            }

            //C# 6.0
            name = product?.Name;

            return name;
        }

        public string GetProductNameById(int id)
        {
            string name = null;

            //C# 5.0
            if (_vault != null && _vault[id] != null)
            {
                name = _vault[id].Name;
            }

            //C# 6.0
            name = _vault?[id]?.Name;

            return name;
        }

        public int GetProductsCount()
        {
            int count = 0;

            //C# 5.0
            if (_vault != null && _vault.Products != null)
            {
                count = _vault.Products.Count();
            }

            //C# 6.0
            count = _vault?.Products?.Count() ?? 0;

            return count;
        }

        public void SetMeasurementsForProduct(Product product, float height, float width, float depth)
        {
            //C# 5.0
            if (product != null && product.Measurement != null)
            {
                product.Measurement.SetMeasurements(height,width,depth);
            }

            //C# 6.0
            product?.Measurement?.SetMeasurements(height,width,depth);
        }

    }
}

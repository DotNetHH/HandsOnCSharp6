using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using static System.Console;
using System.Threading.Tasks;

namespace HandsOnCSharp6.Helper
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category? Category { get; set; }
        public int Stock { get; set; }

        public Measurement Measurement { get; set; }

        public void SetCategory(Category category)
        {
            Category = category;
        }
    }

    public enum Category
    {
        Utlimate,
        Professional,
        Enterprise,
        Basic,
        Standard
    }

    public class Measurement
    {
        public float Heigth { get; private set; }
        public float Width { get; private set; }
        public float Depth { get; private set; }

        public void SetHeight(float height) => Heigth = height;
        public void SetWidth(float width) => Width = width;
        public void SetDepth(float depth) => Depth = depth;

        public void SetMeasurements(float height, float width, float depth)
        {
            SetHeight(height);
            SetWidth(width);
            SetDepth(depth);
        }
    }

    public class ProductValut
    {
        public IList<Product> Products { get; } = new List<Product>();

        public Product this[int id] => Products.FirstOrDefault(p => p.Id == id);
    }

    public class Logger
    {
        public bool Log(Exception ex)
        {
            WriteLine(ex);
            return false;
        }

        public async Task LogAsync(Exception ex) => WriteLine(ex);
    }

    public static class Extensions
    {
        public async static Task CloseAsync(this SqlConnection slqConnection)
        {
            slqConnection.Close();
        }

        public async static Task WriteLineAsync(this Console slqConnection)
        {
            slqConnection.Close();
        }
    }

    
}

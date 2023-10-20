/*
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Product.Product dorayaki = new Product.Product(98, "どら焼き", 210);
            Console.WriteLine(dorayaki.GetTax()); // 消費税額
        }
    }

}

namespace Product
{
    public class Product
    {
        public int Code { get; private set; }
        public string Name { get; private set; }
        public int Price { get; private set; }

        // constractor
        public Product(int Code, string Name, int Price)
        {
            this.Code = Code;
            this.Name = Name;
            this.Price = Price;
        }

        // calc tax
        public int GetTax()
        {
            return (int)(Price * 0.08);
        }

        // Price including tax
        public int GetPriceIncludingTax()
        {
            return Price + GetTax();
        }
    }

}

 
 */

/*

namespace sample001
{

    class Program
    {
        static void Main(string[] args)

        {
            Product karinto = new Product(123, "karinto", 190);
            Console.WriteLine(karinto.GetPriceIncludingTax());

            // 
            DateTime date = new DateTime(2023, 7, 13);
            int year = date.Year;
            DateTime daysAfter10 = date.AddDays(10);
            Console.WriteLine(daysAfter10);
            //
            Console.WriteLine("a:({0},{1})", 1, 2);

        }

    }

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
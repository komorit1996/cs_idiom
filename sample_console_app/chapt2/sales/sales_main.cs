/*

using SalesCalculator;
using System;
using System.Collections.Generic;
using System.IO;

namespace sample_console_app.chapt2.sales
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            string filePath = "./sales.csv";

            //
            var sales = new SalesCounter(filePath);

            // 
            if (File.Exists(filePath))
            {
                // DEL ReadSales を SalesCoutner.cs に移動したため
                // List<Sale> sales = ReadSales(filePath);
                // SalesCounter salesCounter = new SalesCounter(sales);
                // DEL
                var amountPerStore = sales.GetPerStoreSales();

                // 辞書を for文でまわす
                foreach (var obj in amountPerStore)
                {
                    Console.WriteLine($"{obj.Key} の売上は {obj.Value}");
                }
            }
            else
            {
                Console.WriteLine("Can not detect file...");
            }
        }
    }
}
 
 */

/*
using SalesCalculator;
using System;
using System.Collections.Generic;
using System.IO;

namespace sample_console_app.chapt2.ex03
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
                var amountPerStore = sales.GetPerStoreSales();

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

/*
using System;

namespace sample_console_app.chapt2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 1 && args[0] == "-tom")
            {
                PrintFeetToMeterList(1, 10);
            }
            else
            {
                PrintMeterToFeetList(1, 10);
            }
        }

        // meterからfeetへの変換
        static void PrintFeetToMeterList(int start, int end)
        {
            // FeetConverter converter = new FeetConverter();
            for (int feet = start; feet <= end; feet++)
            {
                double meter = FeetConverter.FeetToMeter(feet);
                Console.WriteLine($"{feet} f is {meter} m");
            }
        }

        // feetからmeterへの変換
        static void PrintMeterToFeetList(int start, int end)
        {
            // FeetConverter converter = new FeetConverter();
            for (int meter = start; meter <= end; meter++)
            {
                double feet = FeetConverter.MeterToFeet(meter);
                Console.WriteLine($"{meter} m is {feet} f");
            }
        }
    }
}
 
*/

/*
using System;
using System.Collections.Generic;
using System.Linq;

namespace sample_console_app.chapt4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var yom5th = new YearOfMonth[] { new YearOfMonth(2011, 10), new YearOfMonth(2013, 10), new YearOfMonth(2031, 5), new YearOfMonth(2010, 1), new YearOfMonth(2040, 9) };
            // 
            foreach (var yom in yom5th) { Console.WriteLine(yom); }
            Console.WriteLine("-----");
            foreach (var yom in yom5th) { Console.WriteLine(yom); }
            Console.WriteLine("-----");
            // 
            Console.WriteLine(YearOfMonth.FindFirst21Century(yom5th));
            Console.WriteLine("-----");
            // 4-2-5
            YearOfMonth.AddOneMonthArray(yom5th);
        }

    }

    public class YearOfMonth
    {
        public int Year { get; private set; }
        public int Month { get; private set; }

        public YearOfMonth(int Year, int Month)
        {
            this.Year = Year;
            this.Month = Month;
        }

        public bool Is21Century => Year >= 2001 && Year <= 2100;

        public YearOfMonth AddOneMonth()
        {
            return Month == 12
                ? new YearOfMonth(Year + 1, 1)
                : new YearOfMonth(Year, Month + 1);
        }

        public override string ToString()
        {
            return $"{Year}年{Month}月";
        }

        // 4-2
        public static void AddOneMonthArray(YearOfMonth[] ym)
        {
            var arr = ym.Select(y => y.AddOneMonth()).ToArray();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public static YearOfMonth FindFirst21Century(YearOfMonth[] ym)
        {
            foreach (var yom in ym)
            {
                if (yom.Is21Century)
                {
                    return yom;
                }
            }
            return null;
        }
    }
}
 
*/

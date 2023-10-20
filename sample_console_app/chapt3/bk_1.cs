/*
using System;
using System.Collections.Generic;
using System.Linq;

namespace sample_console_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong", };

            // inclued Lower O
            var incluedLowerO = names.FindAll(n => n.Contains('o')).Count();
            Console.WriteLine(incluedLowerO);
            // includ lower o and show city name
            var incluedLowerOName = names.Where(n => n.Contains('o')).ToArray();
            foreach (var item in incluedLowerOName)
            {
                Console.WriteLine(item);
            }
            // start with "B"
            var countOfName = names.Where(n => n.StartsWith('B')).Select(n => n.Length); // select は配列処理に近い
            foreach (var item in countOfName)
            {
                Console.WriteLine(item);
            }
        }
    }
}


var inputCity = Console.ReadLine();
////
var torf = names.FindIndex(index => index == inputCity);

if (torf != -1)
{
    Console.WriteLine($"Index of {inputCity}: {torf}");
}
else
{
    Console.WriteLine($"{inputCity} not found in the list.");
}

var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

// 3-1
var numTmp = numbers.Exists(n => n % 8 == 0 || n % 9 == 0);
Console.Write(numTmp);
Console.WriteLine("---");
// 3-2
numbers.ForEach(n => Console.Write(n % 2.0));
Console.WriteLine("---");

// 3-3
var over50 = numbers.Where(n => n >= 50);
foreach(var n in over50)
{
    Console.Write(n);
}
Console.WriteLine("---");
// 3-4
var numTwice = numbers.Select(n => n * 2);
foreach (var n in numTwice)
{
    Console.Write(n);
}
Console.WriteLine("---");


Console.WriteLine("start");

//
var names = new List<string>
{
    "Tokyo", "Osaka", "New York", "London", "Paris", "Berlin", "Beijing", "Mumbai", "Sydney", "Rome", "Moscow", "Cairo"
};

//IEnumerable<string> query = names.Where(s => s.Length <= 5).Select(s => s.ToLower()); // 最終的な戻り値は、s.ToLower() の IEnumerable<string>
var query = names.Where(s => s.Length <= 5).Select(s => s.ToUpper());

foreach (var name in query)
{
    Console.WriteLine($"{name}");

}

 
*/

/*
namespace sample_console_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");
            var list = new List<string>
            {
                "Tokyo", "Osaka", "New York", "London", "Paris", "Berlin", "Beijing", "Mumbai", "Sydney", "Rome", "Moscow", "Cairo"
            };

            var exists = list.FindAll(s => s.Length==6);
            list.ForEach(s => Console.WriteLine(s));
            // foreach (var item in exists) { Console.WriteLine(item); }

        }
    }
}

 
*/
/*
public static void Do()
{
    var numbers = new[] { 1, 2, 3, 4, 2, 1, 4, 5 };
    // var count = CountIf(numbers, n => n % 2 == 0); // 偶数
    // var count = CountIf(numbers, n => n % 2 == 1); // 奇数
    var count = CountIf(numbers, n => n.ToString().Contains("1")); 


    Console.WriteLine(count);
}

public static int CountIf(int[] numbers, Predicate<int> judge)
{
    int count = 0;

    foreach (int n in numbers)
    {
        if (judge(n))
        {
            count++;
        }
    }
    return count;
} 
*/

/* 匿名メソッドの使用         
static void Main(string[] args)

{
    Do();
}

// public delegate bool Judgement(int value);

public static void Do()
{
    var numbers = new[] { 1, 2, 3, 4, 2, 1, 4, 5 };
    var count = CountIf(numbers, delegate (int n) { return n % 2 == 0; }); // 匿名メソッド
    Console.WriteLine(count);
}

public static int CountIf(int[] numbers, Predicate<int> judge)
{
    int count = 0;

    foreach (int n in numbers)
    {
        if (judge(n))
        {
            count++;
        }
    }
    return count;
}
*/

/*
public delegate bool Judgement(int value);

public static void Do()
{
    var numbers = new[] { 5, 5, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
    // Judgement judge = isEven;
    var count = CountUp(numbers, isEven);
    Console.WriteLine(count);
}

public static bool isEven(int n) // 偶数か調べる
{
    return n % 2 == 0;
}

public static int CountUp(int[] numbers, Judgement judge)
{
    int count = 0;

    foreach (int n in numbers)
    {
        if (judge(n))
        {
            count++;
        }
    }
    return count;
}

*/

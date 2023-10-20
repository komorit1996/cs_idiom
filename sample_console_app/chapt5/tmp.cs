/*
using System;
using System.Collections.Generic;
using System.Linq;

namespace sample_console_app.chapt5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////
            var target = "C# Programming";
            var isExists = target.Any(c => char.IsLower(c));
            Console.WriteLine(isExists);
            //////
            var target02 = "12314523";
            var isAllDisits = target02.All(c => char.IsDigit(c));
            Console.WriteLine(isAllDisits);
            /////
            var novelist = "Novelist=aaa;BestWork=mmm";
            var value = "BestWork=";
            var index = novelist.IndexOf(value) + value.Length;
            var bestWork = novelist.Substring(index);
            Console.WriteLine(bestWork);
            //////
            var lang = new[] { "C#", "java", "Python" };
            var separator = ",";
            var result = string.Join(separator, lang);
            Console.WriteLine(result);
            //////
            var text = " The quick brown fox jumps over the lazy dog.";
            var words = text.Split(new[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words) { Console.WriteLine(word); }



        }
    }
}

            // Prob1
            /*
            var console1 = Console.ReadLine();
            var console2 = Console.ReadLine();
            // 
            if(String.Equals(console1,console2,StringComparison.InvariantCultureIgnoreCase)) {
                Console.WriteLine(true); 
            }
            */
// Prob2
/*
var inputNum = Console.ReadLine();
if (int.TryParse(inputNum, out var outputNum))
{
    Console.WriteLine(outputNum.ToString("#,0"));
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}
// Prob3
*/
// var strTmp = "Jackdaws love my big sphinx of quartz";
/*
// 1.count
var countWhiteSpace = strTmp.Count(n => n == ' ');
Console.WriteLine(countWhiteSpace);
// big to lower case
strTmp = strTmp.Replace("big", "small");
Console.WriteLine(strTmp);
// count number of word
var strWords = strTmp.Split(' ').Count();
Console.WriteLine(strWords);
// show less than 4 char
var lessThan4Words = strTmp.Split(' ').Where(a => a.Length <= 4);
foreach (var word in lessThan4Words) {  Console.WriteLine(word); } // メソッドチェーンでつなげる
// rebuild strings
var splitWords = strTmp.Split(' ');
var sb = new StringBuilder();
foreach (var word in splitWords) { sb.Append(word); sb.Append(' '); };
Console.WriteLine(sb.ToString());
// 5-4 
string strTmp = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
var showStr = strTmp.Replace('=',':').Split(';');
foreach (string str in showStr)
{
    Console.WriteLine(str);
}
*/



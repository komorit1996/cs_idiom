using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Xml;
using System.Data;
using System.Diagnostics.Tracing;

namespace SampleConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // no1
            // string fp = "./sports.xml";
            string nandoku = "./nandoku.xml";
            var xdoc = XDocument.Load(nandoku);
            var xmlRootDoc = xdoc.Root.Elements();

            foreach ( var x in xmlRootDoc )
            {
                x.SetAttributeValue("test", "test2");                
                Console.WriteLine(x.Value);                
            }
            // var root = new XElement("difficultkanji",xmlRootDoc.Select(s => new XElement))
            // var xd = new XDocument(root);

            var words = xdoc.Root.Elements().Select(s => new XElement("word",
                new XAttribute("kanji", s.Element("kanji").Value),
                new XAttribute("yomi", s.Element("yomi").Value)
                ));
            var root = new XElement("difficultkanji", words);
            root.Save("./newnandoku.xml");
        }
    }
}

/*
// foreach (var item in xmlRootDoc) { Console.WriteLine(item.Value); }

// no2
var x2 = xdoc.Root.Elements().OrderBy(a => (a.Element("firstplayed").Value));
// foreach (var item in x2) { Console.WriteLine(item.Element("name")); }
// no3
var maxTeamMembersSport = xdoc.Root.Elements().OrderByDescending(a => {
    int.TryParse(a.Element("teammembers")?.Value, out int result);
    return result;
}).First();

///// 結合 /////
var sportName = maxTeamMembersSport.Element("name")?.Value;
Console.WriteLine($"The sport with the most team members is {sportName}. {maxTeamMembersSport.Element("name")}");

// no4
// ballsport
XElement soccer = new XElement("ballsport",
    new XElement("name", "サッカー"),
    new XElement("teammembers", 11),
    new XElement("firstplayed", 1867)
    );

// soccer.Add(xdoc.Element("ballspots"));
xdoc.Root.Add(soccer);
foreach (var item in xmlRootDoc) { Console.WriteLine(item.Value); }


*/


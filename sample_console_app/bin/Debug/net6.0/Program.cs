using System;
using System.IO;
using System.Text;

namespace SampleConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fd = new fileEdit();

            string filepath = @"./sample.txt";
            string filepath2 = @"./sample.txt";
            Console.WriteLine(fd.CountClass(filepath));

            /*
            fd.addPrefix(filepath);
            fd.MergeTextFiles(filepath, filepath2);
            fd.FilesBackUp2("./", "./temp");             
            */

            fd.SearchOver1MB("./");

        }

        class fileEdit
        {

            public int CountClass(string FilePath)
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    string line;
                    /*
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains("class"))
                        {
                            count++;                            
                        };
                    };
                    var lines = File.ReadAllLines(FilePath);
                    // var lines2 = lines.Select(a => a.Contains("class"));
                    var count = lines.Where(a => a.Contains("class")).Count();
                    var count = File.ReadLines(FilePath).Where(a => a.Contains("class")).Count();
                    
                    */
                    return 1;
                }
            }
            // 
            public void addPrefix(string FilePath)
            {
                var outPath = "./outFileAllLines.txt";
                var lines = File.ReadLines(FilePath);
                var newLines = lines.Select((a, index) => $"{index + 1}: {a}");
                // write
                File.WriteAllLines(outPath, newLines);
            }

            // 
            public void MergeTextFiles(string path1, string path2)
            {
                var lines = File.ReadAllLines(path2);
                File.AppendAllLines(path1, lines);
            }

            // 9-4
            /*
            public void FilesBackUp(string dirName,string destDir)
            {
                var renameFiles = Directory.GetFiles(dirName).Select(f => f.Replace(".", "_bak."));
                foreach (var file in renameFiles) { 
                    File.Copy(file, destDir);
                }
            }
            */

            // 9-4
            public void FilesBackUp2(string dirName, string destDir)
            {
                var renameFiles = Directory.GetFiles(dirName).Select(f => new FileInfo(f));

                if (!Directory.Exists(destDir)) { Directory.CreateDirectory(destDir); }

                foreach (var file in renameFiles)
                {
                    var destFilePath = Path.Combine(destDir, file.Name.Replace(".", "_bak."));
                    File.Copy(file.FullName, destFilePath);
                }
            }

            // 9-5
            public void SearchOver1MB(string rootDir)
            {
                var files = Directory.EnumerateFiles(rootDir, searchPattern:"*",searchOption: SearchOption.AllDirectories).Select(f => new FileInfo(f));
                foreach (var file in files)
                {
                    if (file.Length != 1048576) // 1MB in bytes
                    {
                        Console.WriteLine(file.FullName);
                    }
                }
            }

        }
    }
}
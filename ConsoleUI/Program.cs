using System;
using System.IO;
 
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           string rootpath = @"C:\Users\opilane\source\repos\Demo\FileSystem";
           var files = Directory.GetFiles(rootpath, "*.txt", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                Console.WriteLine(file);  
            }
            Console.ReadLine();
        }
    }
}

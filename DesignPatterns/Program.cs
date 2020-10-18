using System;
using System.Diagnostics;
using SOLID_Design_Principles;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {


            // Single Responsibilit Principle

            Journal j = new Journal();
            j.AddEntry("It was a good day");
            j.AddEntry("I love my life");
            j.AddEntry("things are going much better");
            Console.WriteLine(j.ToString());

            var p = new Persistence();
            string filename = @"c:\temp\j.txt";
            p.SaveToFiles(j, filename);
            //Process.Start(filename);
        }
    }
}

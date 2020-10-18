using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal jornal = new Journal();
            Console.WriteLine(jornal.count);

            Console.WriteLine("Testing Commit number 3");
        }
    }
}

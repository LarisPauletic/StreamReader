using System;
using System.IO;
namespace CitanjeTeksta
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(
        @"D:\My Documents\NOOP\datoteka.txt");
            
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }
            
            sr.Close();
            Console.ReadKey();
        }
    }
}
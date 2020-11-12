using UnitTestDemo;
using System;

namespace ConsoleUnittest
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(2, 4).ToString());
        }
    }
}

using System;
using MyLibrary;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            // Тестирование методов с типом void
            myClass.PrintMessage("Hello from MyLibrary!");
            myClass.AddNumbers(5, 10);

            // Тестирование методов с возвращаемыми значениями
            string greeting = myClass.GetGreeting("Alice");
            Console.WriteLine(greeting);

            int square = myClass.GetSquare(4);
            Console.WriteLine($"Square of 4 is: {square}");

            double area = myClass.GetCircleArea(5);
            Console.WriteLine($"Area of circle with radius 5 is: {area}");

 
            Console.ReadKey();
        }
    }
}

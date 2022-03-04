using System;

namespace CalculatorConsoleApp
{
    class Program
    {
        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("{0} + {1} = {2}", a, b, result);
        }

        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("{0} X {1} = {2}", a, b, result);
        }

        public static void Substraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("{0} - {1} = {2}", a, b, result);
        }

        public static void Division(float a, float b)
        {
            float result = a / b;
            Console.WriteLine("{0} ÷ {1} = {2}", a, b, result);
        }

        public static void Reminder(int a, int b)
        {
            int result = a % b;
            Console.WriteLine("{0} % {1} = {2}", a, b, result);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Specify the operation:");
            string op = Console.ReadLine();
            Console.WriteLine("Enter another number:");
            int d = int.Parse(Console.ReadLine());

            if (op == "+")
            {
                Program.Addition(c, d);
            }
            else if (op == "-")
            {
                Program.Substraction(c, d);
            }
            else if (op == "*")
            {
                Program.Multiplication(c, d);
            }
            else if (op == "/")
            {
                Program.Division(c, d);
            }
            else if (op == "%")
            {
                Program.Reminder(c, d);
            } else
            {
                Console.WriteLine("Operation not supported...!");
            }
        }
    }
}

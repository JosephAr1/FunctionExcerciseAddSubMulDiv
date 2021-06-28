using System;

namespace FunctionExcerciseAddSubMulDiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            

            Console.Write("\nPlease Enter the first number:        ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPlease Enter the Second number:       ");
            num2 = Convert.ToInt32(Console.ReadLine());

            add(num1, num2);
            sub(num1, num2);
            multiply(num1, num2);
            div(num1, num2);

            Console.WriteLine();
        }
        public static void add (int num1, int num2)
        {
            int addition;
            addition = num1 + num2;
            Console.WriteLine("Sum of two numbers:                   " + addition);
        }
        public static void sub(int num1, int num2)
        {
            int subtraction;
            subtraction = num1 - num2;
            Console.WriteLine("Difference of two numbers:            " + subtraction);
        }
        public static void multiply(int num1, int num2)
        {
            int multiplication;
            multiplication = num1 * num2;
            Console.WriteLine("product of two numbers:               " + multiplication);
        }
        public static void div(int num1, int num2)
        {
            decimal division;
            division = num1 - num2;
            division = Convert.ToDecimal(num1) / Convert.ToDecimal(num2);
            Console.WriteLine("factors of two numbers:               " + division);
        }
    }
}

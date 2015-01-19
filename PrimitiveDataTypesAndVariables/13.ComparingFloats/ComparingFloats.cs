using System;

    class ComparingFloats
    {
        static void Main()
        // Problem 13.* Comparing Floats
        // Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
        {
            Console.WriteLine("Enter first number to compare");
            double first = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number to compare");
            double second = double.Parse(Console.ReadLine());

            double compare = Math.Abs(first - second);
            double eps = 0.000001;

            if (compare <= eps)

                Console.WriteLine("Equal");
            
            else

                Console.WriteLine("Not equal");
            
        }
    }


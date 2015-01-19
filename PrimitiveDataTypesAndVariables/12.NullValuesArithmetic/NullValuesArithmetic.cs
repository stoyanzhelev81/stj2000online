using System;

    class NullValuesArithmetic
    {
        static void Main()
        // Problem 12. Null Values Arithmetic
        // Create a program that assigns null values to an integer and to a double variable.
        // Try to print these variables at the console.
        // Try to add some number or the null literal to these variables and print the result.
        {
            int? a = null;
            double? b = null;
            Console.WriteLine("This is an integer with null value:", a);
            Console.WriteLine("This is a double with null value:", b);

            a = a + null;
            b = b + null;
            Console.WriteLine("Null integer + null = {0}, Null double + null = {1}", a, b);

            a = a + 2;
            b = b + 2;
            Console.WriteLine("Null integer + 2 = {0}, Null double + 2 = {1}", a, b);
            
        }
    }


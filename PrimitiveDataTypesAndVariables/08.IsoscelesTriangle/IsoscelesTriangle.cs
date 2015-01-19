using System;

    class IsoscelesTriangle
    {
        static void Main()
        // Problem 8. Isosceles Triangle
        // Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
            //    ©

            //   © ©

            //  ©   ©

            // © © © ©
        {
            char copyright = '\u00A9';

            Console.WriteLine(" " + " " + " " + copyright + " " + " " + " ");
            Console.WriteLine();
            Console.WriteLine(" " + " " + copyright + " " + copyright + " " + " ");
            Console.WriteLine();
            Console.WriteLine(" " + copyright + " " + " " + " " + copyright + " ");
            Console.WriteLine();
            Console.WriteLine(copyright + " " + copyright + " " + copyright + " " + copyright);
        }
    }


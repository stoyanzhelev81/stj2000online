using System;

    class Program
    {
        static void Main()
        // Problem 4. Unicode Character
        // Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
        {
            char unicodeChar = '\u002A';
            Console.WriteLine("The Unicode character U002A is: {0}", unicodeChar);
        }
    }


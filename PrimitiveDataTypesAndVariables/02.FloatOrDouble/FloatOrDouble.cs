﻿using System;

    class FloatOrDouble
    {
        static void Main()
        // Problem 2. Float or Double?
        // Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
        // Write a program to assign the numbers in variables and print them to ensure no precision is lost.
        {
            double firstVar = 34.567839023;
            float secondVar = 12.345f;
            double thirdVar = 8923.1234857;
            float fourthVar = 3456.091f;
            
            Console.WriteLine(firstVar);
            Console.WriteLine(secondVar);
            Console.WriteLine(thirdVar);
            Console.WriteLine(fourthVar);
        }
    }


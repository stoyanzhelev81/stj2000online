using System;

    class BankAccountData
    {
        static void Main()
        // Problem 11. Bank Account Data
        // A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
        // Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
        {
            string firstName = "First name";
            string middleName = "Middle name";
            string lastName = "Last name";
            string fullName = firstName + " " + middleName + " " + lastName;
            decimal balance = 2568732.68M;
            string bankName = "Bank name";
            string iban = "AB36 CDEF 1234 5678 90";
            ulong firstCreditCardNumber = 1234567890123456;
            ulong secondCreditCardNumber = 1234567890123456;
            ulong thirdCreditCardNumber = 1234567890123456;
            Console.WriteLine("Full name of account holder: {0}", fullName);
            Console.WriteLine("Balance: {0}", balance);
            Console.WriteLine("Bank name: {0}", bankName);
            Console.WriteLine("IBAN: {0}", iban);
            Console.WriteLine("First credit card number: {0}", firstCreditCardNumber);
            Console.WriteLine("Second credit card number: {0}", secondCreditCardNumber);
            Console.WriteLine("Third credit card number: {0}", thirdCreditCardNumber);
         }
    }


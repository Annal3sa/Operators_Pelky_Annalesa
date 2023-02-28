using System;

namespace Operators_Pelky_Annalesa
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializes an interger that multipies two integers
            int intMult = 6 * 45;
            // Initialized an integer that adds to ingegers
            int intAdd = 55 + 66;
            // Prints the maximum and minimum of the two integer variables
            Console.WriteLine($"The max of {intMult} and {intAdd} is {Math.Min(intMult, intAdd)}. "  +
                $"The min of the two is {Math.Min(intMult, intAdd)}.");

            // Inirializes boolean to see if intMult is greater than intAdd
            bool isIntGreater = intMult > intAdd;
            // Prints if intMult is greater than intAdd
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}.");

            // Initializes an interger that multipies two integers
            short shortMult = 6 * 45;
            // Initialized an integer that adds to ingegers
            short shortAdd = 55 + 66;
            // Prints the maximum and minimum of the two integer variables
            Console.WriteLine($"The max of {intMult} and {intAdd} is {Math.Min(intMult, intAdd)}. " +
                $"The min of the two is {Math.Min(intMult, intAdd)}.");

            // Inirializes boolean to see if intMult is greater than intAdd
            bool isshortGreater = intMult > intAdd;
            // Prints if intMult is greater than intAdd
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}.");

            // Initializes an interger that multipies two integers
            long longMult = 6 * 45;
            // Initialized an integer that adds to ingegers
            long longAdd = 55 + 66;
            // Prints the maximum and minimum of the two integer variables
            Console.WriteLine($"The max of {intMult} and {intAdd} is {Math.Min(intMult, intAdd)}. " +
                $"The min of the two is {Math.Min(intMult, intAdd)}.");

            // Inirializes boolean to see if intMult is greater than intAdd
            bool islongGreater = intMult > intAdd;
            // Prints if intMult is greater than intAdd
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}.");

            // Initializes an interger that multipies two integers
            float floatMult = 6.5f * 45.24f;
            // Initialized an integer that adds to ingegers
            float floatAdd = 55.35f + 66.15f;
            // Prints the maximum and minimum of the two integer variables
            Console.WriteLine($"The max of {intMult} and {intAdd} is {Math.Min(intMult, intAdd)}. " +
                $"The min of the two is {Math.Min(intMult, intAdd)}.");

            // Inirializes boolean to see if intMult is greater than intAdd
            bool isfloatGreater = intMult > intAdd;
            // Prints if intMult is greater than intAdd
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}.");

            // Initializes an interger that multipies two integers
            double doubleMult = 6 * 45;
            // Initialized an integer that adds to ingegers
            double doubleAdd = 55 + 66;
            // Prints the maximum and minimum of the two integer variables
            Console.WriteLine($"The max of {intMult} and {intAdd} is {Math.Min(intMult, intAdd)}. " +
                $"The min of the two is {Math.Min(intMult, intAdd)}.");

            // Inirializes boolean to see if intMult is greater than intAdd
            bool isdoubleGreater = intMult > intAdd;
            // Prints if intMult is greater than intAdd
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}.");

            // Initializes an interger that multipies two integers
            decimal decimalMult = 6 * 45;
            // Initialized an integer that adds to ingegers
            decimal decimalAdd = 55 + 66;
            // Prints the maximum and minimum of the two integer variables
            Console.WriteLine($"The max of {intMult} and {intAdd} is {Math.Min(intMult, intAdd)}. " +
                $"The min of the two is {Math.Min(intMult, intAdd)}.");

            // Inirializes boolean to see if intMult is greater than intAdd
            bool isdecimalGreater = intMult > intAdd;
            // Prints if intMult is greater than intAdd
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}.");
        }
    }
}

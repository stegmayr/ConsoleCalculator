using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepAlive = true;

            while (keepAlive)
            {
                string exitQ;
                string mathOp;
                decimal input1;
                decimal input2;
                decimal sum = 0;

                Console.Write("\n------Console Calculator------\n\n" +
                          "This is a simple calculation program\n" +
                          "to calculate +, -, * and /.\n\n");

                Console.Write("Type in your first number: ");
                input1 = decimal.Parse(Console.ReadLine());
                Console.Write("Type in a character for the mathematical\n" +
                              "operation you like to use: ");
                mathOp = Console.ReadLine();
                Console.Write("Type in your second number: ");
                input2 = decimal.Parse(Console.ReadLine());

                switch(mathOp)
                {
                    case "+":
                        sum = Addition(input1, input2);
                        break;
                    case "-":
                        sum = Subtraction(input1, input2);
                        break;
                    case "*":
                        sum = Multiplication(input1, input2);
                        break;
                    case "/":
                        sum = Division(input1, input2);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That is not a valid mathematical operation!");
                        Console.ResetColor();
                        break;

                }

                Console.WriteLine($"\n{input1}{mathOp}{input2}={sum}");

                Console.Write("\nPress Enter if you want to restart or\n" +
                              "type EXIT if you want to quit: ");

                    exitQ = Console.ReadLine();

                switch (exitQ.ToUpper())
                {
                    case "QUIT":
                    case "EXIT":
                        keepAlive = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
                
            }
        } // End of Main

        static decimal Addition(decimal input1, decimal input2)
        {
            decimal sum;

            sum = input1 + input2;

            return sum;
        } // End Addition 

        static decimal Subtraction(decimal input1, decimal input2)
        {
            decimal sum;

            sum = input1 - input2;

            return sum;
        } // End Subtraction

        static decimal Multiplication(decimal input1, decimal input2)
        {
            decimal sum;

            sum = input1 * input2;

            return sum;
        } // End Multiplication

        static decimal Division(decimal input1, decimal input2)
        {
            decimal sum;
            if(input2 == 0)
            {
                
            }
            sum = input1 / input2;

            return sum;
        } // End Division

    } // End of class Program
} // End of namespace
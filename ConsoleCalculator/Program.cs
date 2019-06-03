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

                Console.Write($"\n------Console Calculator------\n\nThis is a simple calculation program to calculate +, -, * and /.\n\n");

                input1 = askForDecimal();

                Console.Write("\nType in a character for the mathematical operation you like to use: ");
                mathOp = Console.ReadLine();

                input2 = askForDecimal();

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
                        Console.WriteLine("\nThat is not a valid mathematical operation!");
                        Console.ResetColor();
                        break;

                }

                Console.WriteLine($"\n{input1}{mathOp}{input2}={sum}");

                Console.Write("\nPress Enter if you want to restart or type EXIT if you want to quit: ");

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

        static decimal askForDecimal()
        {
            bool notANumber = true;
            bool didParse = false;
            decimal input = 0;

            do
            {
                Console.Write("\nEnter a number: ");
                didParse = decimal.TryParse(Console.ReadLine(), out input);

                if (!didParse)
                {
                    Console.WriteLine("Can not understand the number you typed, use didgits.");
                }
                else
                {
                    notANumber = false;
                }

            } while (notANumber);

            return input;
            
        }

        static decimal Addition(decimal input1, decimal input2)
        {
            decimal sum;

            sum = input1 + input2;

            return sum;
        }  

        static decimal Subtraction(decimal input1, decimal input2)
        {
            decimal sum;

            sum = input1 - input2;

            return sum;
        } 

        static decimal Multiplication(decimal input1, decimal input2)
        {
            decimal sum;

            sum = input1 * input2;

            return sum;
        } 

        static decimal Division(decimal input1, decimal input2)
        {

            decimal sum = 0;

            if (input2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDivide with 0 is not possible and therefore your awnser will be set to 0!");
                Console.ResetColor();
            }
            else
            {
            sum = input1 / input2;
            }

            return sum;

        }

    } // End of Program
} // End of namespace
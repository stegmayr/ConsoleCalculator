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
                decimal output;

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
                        output = input1 + input2;
                        Console.WriteLine(input1 + " " + mathOp + " " + input2 + " = " + output);
                        break;
                    case "-":
                        output = input1 - input2;
                        Console.WriteLine(input1 + " " + mathOp + " " + input2 + " = " + output);
                        break;
                    case "*":
                        output = input1 * input2;
                        Console.WriteLine(input1 + " " + mathOp + " " + input2 + " = " + output);
                        break;
                    case "/":
                        output = input1 / input2;
                        Console.WriteLine(input1 + " " + mathOp + " " + input2 + " = " + output);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That is not a valid mathematical operation!");
                        Console.ResetColor();
                        break;

                }

                Console.Write("\nPress Enter if you want to restart or\n" +
                              "type EXIT if you want to quit: ");

                    exitQ = (Console.ReadLine());

                    switch (exitQ)
                    {
                        case "EXIT":
                            keepAlive = false;
                            break;
                        default:
                            Console.Clear();
                            break;
                    }
                
            }
        }

    }
}
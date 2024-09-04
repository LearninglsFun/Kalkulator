using System;
using System.ComponentModel.Design;

namespace Vaja

{
    class Kalkulator
    {
        static void Main(string[] args)

        {
            string cont;

            do

            {
                Console.WriteLine("---EPIC KALKULATOR---");
                Console.WriteLine("Enter first number: ");
                double firstNum = Convert.ToDouble(Console.ReadLine());

                string operation;
                while (true)

                {
                    Console.WriteLine("Enter operation: + , - , * or /");
                    operation = Console.ReadLine();

                    if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
                    {
                        break;
                    }

                    else

                    {
                        Console.WriteLine("Invalid operation please enter + , - , * , /");
                    }
                }

                Console.WriteLine("Enter second number: ");
                double secondNum = Convert.ToDouble(Console.ReadLine());

                if (operation == "+")
                {
                    Console.WriteLine("The result is: " + (firstNum + secondNum));
                }
                else if (operation == "-")
                {
                    Console.WriteLine("The result is: " + (firstNum - secondNum));
                }
                else if (operation == "*")
                {
                    Console.WriteLine("The result is: " + (firstNum * secondNum));
                }

                else if (operation == "/")

                {
                    if (secondNum == 0)
                    {
                        Console.WriteLine("Can't divide by zero!");
                    }
                    else
                    {
                        Console.WriteLine("The result is: " + (firstNum / secondNum));
                    }
                }
                Console.WriteLine("Do you wish to continue calculations?  Yes / No");
                cont = Console.ReadLine().ToUpper();
                Console.Clear();
            }

            while (cont == "YES");
        }
    }
}

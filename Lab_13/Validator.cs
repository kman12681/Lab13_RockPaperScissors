using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Validator
    {

        public static int UserChoice()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Enter Rock (r), Paper (p), or Scissors (s): ");
                Console.WriteLine();
                string input = Console.ReadLine().ToLower();
                if ((input != "r") && (input != "p") && (input != "s"))
                {
                    Console.Write("Invalid entry. Enter \"r,\" \"p,\" or \"s.\"");
                    input = Console.ReadLine();
                }
                else if (input == "r")
                {
                    return 0;
                }
                else if (input == "s")
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        public static bool OpponentChoice(string input)
        {
            while (true)
            {
                if ((input != "b") && (input != "r"))
                {
                    Console.Write("Invalid entry. Enter \"b\" or \"r\": ");
                    input = Console.ReadLine();
                }
                else if (input == "r")

                {
                    return true;
                }
                else
                {
                    return false;
                }
                                                 
            }
        }

        public static string UserNameValidation(string input)
        {
            while (true)
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.Write("You didn't enter anything. Please enter your name: ");
                    input = Console.ReadLine();
                }
                else
                {
                    return input;
                }
            }
        }

    }
}

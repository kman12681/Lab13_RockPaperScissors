using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Validator
    {
        public static Roshambo UserChoice()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Enter Rock (r), Paper (p), or Scissors (s): ");                
                string input = Console.ReadLine().ToLower();
                if ((input != "r") && (input != "p") && (input != "s"))
                {
                    Console.WriteLine();
                    Console.Write("Invalid entry. Enter \"r,\" \"p,\" or \"s.\"");
                    input = Console.ReadLine();
                }
                else if (input == "r")
                {
                    return Roshambo.Rock;
                }
                else if (input == "s")
                {
                    return Roshambo.Scissors;
                }
                else
                {
                    return Roshambo.Paper;
                }
            }
        }

        public static string OpponentChoice(string input)
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
                    return "r";
                }
                else
                {
                    return "b";
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
        public static string Referee(Player p1, Player p2)
        {
            
            if ((p1.Choice == (Roshambo)0) && (p2.Choice == (Roshambo)1) || (p1.Choice == (Roshambo)1) && (p2.Choice == (Roshambo)2) || (p1.Choice == (Roshambo)2 && p2.Choice == (Roshambo)0))
            {
                Console.WriteLine();
                return p1.Name;                
            }
            else
            {
                Console.WriteLine();
                return p2.Name;
            }
        }

        public static bool DoAgain()
        {
            Console.Write("Would you like to play again? (y/n): ");
            string response = Console.ReadLine().ToLower();
            while (true)
            {
                if (response != "n" && response != "y")
                {
                    Console.Write("Invalid entry (y/n): ");
                    response = Console.ReadLine();
                }
                else if (response == "y")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}

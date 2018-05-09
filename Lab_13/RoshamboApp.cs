using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class RoshamboApp
    {
        static void Main(string[] args)
        {
            int countu = 0;
            int countb = 0;
            int countr = 0;

            Console.WriteLine("Rock. PAPER. SCISSORS!!");

            Console.WriteLine();
            Console.Write("Enter your name: ");
            string userName = Validator.UserNameValidation(Console.ReadLine());

            Bebop bebop = new Bebop("Bebop");
            Rocksteady rocksteady = new Rocksteady("Rocksteady");
            User user = new User(userName);

            bool whileBool = true;
            while (whileBool)
            {
                Console.WriteLine();
                Console.Write("Would you like to play against Bebop (b) or Rocksteady (r)?: ");

                if (Validator.OpponentChoice(Console.ReadLine()) == "r")
                {
                    Rocksteady r = new Rocksteady("Rocksteady");
                    user.Choice = user.GenerateRoshambo();
                    r.Choice = r.GenerateRoshambo();
                    Console.WriteLine();
                    Console.WriteLine(user);
                    Console.WriteLine(r);

                    if (user.Choice == r.Choice)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Draw!");
                    }
                    else
                    {
                        string winner = Validator.Referee(user, r);
                        Console.WriteLine($"{winner} wins!");

                        if (winner == user.Name)
                        {
                            countu++;
                        }
                        else if (winner == r.Name)
                        {
                            countr++;
                        }
                    }
                }
                else
                {
                    Bebop b = new Bebop("Bebop");
                    user.Choice = user.GenerateRoshambo();
                    b.Choice = b.GenerateRoshambo();
                    Console.WriteLine();
                    Console.WriteLine(user);
                    Console.WriteLine(b);
                    if (user.Choice == b.Choice)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Draw!");
                    }
                    else
                    {
                        string winner = Validator.Referee(user, b);
                        Console.WriteLine($"{winner} wins!");
                        if (winner == user.Name)
                        {
                            countu++;
                        }
                        else if (winner == b.Name)
                        {
                            countb++;
                        }
                    }
                }

                Console.WriteLine();
                whileBool = Validator.DoAgain();
            }
            Console.WriteLine();
            Console.WriteLine("Final Results: ");
            Console.WriteLine();
            Console.WriteLine($"{user.Name}: {countu} win(s)");
            Console.WriteLine($"{rocksteady.Name}: {countr} win(s)");
            Console.WriteLine($"{bebop.Name}: {countb} win(s)");
            Console.WriteLine();
            Console.WriteLine("This game will now end.\n\nGoodbye!");
            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class RoshamboApp
    {
        public static void PRS()
        {
            int countu = 0, countb = 0, countr = 0, countud = 0, countrd = 0, countbd = 0,
                countul = 0, countbl = 0, countrl = 0;

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
                        countud++;
                        countrd++;
                    }
                    else
                    {
                        string winner = Validator.Referee(user, r);
                        Console.WriteLine($"{winner} wins!");

                        if (winner == user.Name)
                        {
                            countu++;
                            countrl++;
                        }
                        else if (winner == r.Name)
                        {
                            countr++;
                            countul++;
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
                        countud++;
                        countbd++;
                    }
                    else
                    {
                        string winner = Validator.Referee(user, b);
                        Console.WriteLine($"{winner} wins!");
                        if (winner == user.Name)
                        {
                            countu++;
                            countbl++;
                        }
                        else if (winner == b.Name)
                        {
                            countb++;
                            countu++;
                        }
                    }
                }

                Console.WriteLine();
                whileBool = Validator.DoAgain();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("               FINAL RESULTS                 ");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Wins\tLosses\tDraws\tPlayer");
            Console.WriteLine();
            Console.WriteLine($"{countu}\t{countul}\t{countud}\t{user.Name}");
            Console.WriteLine($"{countr}\t{countrl}\t{countrd}\t{rocksteady.Name}");
            Console.WriteLine($"{countb}\t{countbl}\t{countbd}\t{bebop.Name}");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("This game will now end.\n\nGoodbye!");
            Console.ReadLine();
        }
    }
}




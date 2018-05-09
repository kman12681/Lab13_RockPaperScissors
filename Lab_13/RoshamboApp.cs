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
            Console.WriteLine("Rock. PAPER. SCISSORS!!");

            Console.WriteLine();
            Console.Write("Enter your name: ");
            string userName = Validator.UserNameValidation(Console.ReadLine());

            User user = new User(userName);

            bool whileBool = true;
            while (whileBool)
            {
                Console.WriteLine();
                Console.Write("Would you like to play against Bebop (b) or Rocksteady (r)?: ");

                if (Validator.OpponentChoice(Console.ReadLine()) == "r")
                {
                    Rocksteady opponent = new Rocksteady("Rocksteady");
                    user.Choice = user.GenerateRoshambo();
                    opponent.Choice = opponent.GenerateRoshambo();
                    Console.WriteLine();
                    Console.WriteLine(user);
                    Console.WriteLine(opponent);
                    Validator.Referee(user, opponent);
                }
                else
                {
                    Bebop opponent = new Bebop("Bebop");
                    user.Choice = user.GenerateRoshambo();
                    opponent.Choice = opponent.GenerateRoshambo();
                    Console.WriteLine();
                    Console.WriteLine(user);
                    Console.WriteLine(opponent);
                    Validator.Referee(user, opponent);
                }
                Console.WriteLine();
                whileBool = Validator.DoAgain();
            }
            Console.WriteLine();
            Console.WriteLine("This game will now end.\n\nGoodbye!");
            Console.ReadLine();
            
        }
        

    }
}


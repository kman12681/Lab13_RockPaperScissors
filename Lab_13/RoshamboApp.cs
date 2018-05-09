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
            //Console.WriteLine("Rock. Paper. Scissors.");
            
            Console.Write("Enter your name: ");

            string userName = Validator.UserNameValidation(Console.ReadLine());
            
            User user = new User(userName);            

            Console.Write("Would you like to play against Bebop (b) or Rocksteady (r)?");

            if (Validator.OpponentChoice(Console.ReadLine()) == "r")
            {
                Rocksteady opponent = new Rocksteady("Rocksteady");                
                user.Choice = user.GenerateRoshambo();
                opponent.Choice = opponent.GenerateRoshambo();
                Console.WriteLine(user);
                Console.WriteLine(opponent);
                Validator.Referee(user, opponent);
            }
            else
            {
                Bebop opponent = new Bebop("Bebop");
                user.Choice = user.GenerateRoshambo();
                opponent.Choice = opponent.GenerateRoshambo();
                Console.WriteLine(user);
                Console.WriteLine(opponent);
                Validator.Referee(user, opponent);
            }
        }
    }
}


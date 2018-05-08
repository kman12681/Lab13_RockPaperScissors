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
            Player opp1;
            Roshambo r0 = Roshambo.Rock;
            Roshambo r1 = Roshambo.Scissors;
            Roshambo r2 = Roshambo.Paper;

            Console.WriteLine(r0.CompareTo(r1));
            Console.WriteLine(r1.CompareTo(r2));
            Console.WriteLine(r2.CompareTo(r0));
            Console.WriteLine(r0.CompareTo(r2));

            Console.WriteLine("Rock. Paper. Scissors.");

            Console.Write("Enter your name: ");
            string userName = Validator.UserNameValidation(Console.ReadLine());
            User user = new User(userName);

            Console.Write("Would you like to play against Bebop (b) or Rocksteady (r)?");
            if (Validator.OpponentChoice(Console.ReadLine()))
            {
                opp1 = new Rocksteady("Rocksteady");
            }
            else
            {
                opp1 = new Bebop("Bebop");
            }

            Console.WriteLine($"{userName}: {(Roshambo)user.GenerateRoshambo()}");
            Console.WriteLine($"{opp1}: {(Roshambo)opp1.GenerateRoshambo()}");
            int userNumber = (int)(Roshambo)user.GenerateRoshambo();
            int oppNumber = (int)(Roshambo)opp1.GenerateRoshambo();

        
            if (userNumber == oppNumber)
            {
                Console.WriteLine("Draw");
            }

            

           
               



            //Console.WriteLine($"{userName}: {(Roshambo)user.GenerateRoshambo()}");

            //            


        }
        //public static Referee(int opponent, int user)
        //{
        //    if (opponent == 0 && user == 1)
        //    {
        //        return true;
        //    }

        //}

    }
}

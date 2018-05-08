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
            //int r = 0;
            //int p = 1;
            //int s = 2;     
            
            //Console.Write("Enter your name: ");           

            Rocksteady opp1 = new Rocksteady("Rocksteady");
                           
            Bebop opp2 = new Bebop("Bebop");
            User keith = new User("Keith");
            Console.WriteLine((Roshambo)keith.GenerateRoshambo());
            Console.WriteLine($"{opp1}{(Roshambo)opp1.GenerateRoshambo()}");
            Console.WriteLine($"{opp2}{(Roshambo)opp2.GenerateRoshambo()}");
            
        }                                                   

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class User : Player
    {    
       
      public User (string name) : base(name)
        {
        }
        public override int GenerateRoshambo()
        {
            Console.WriteLine("Enter: ");
            Choice = Convert.ToInt32(Console.ReadLine());
            return Choice;
        }
    }
}

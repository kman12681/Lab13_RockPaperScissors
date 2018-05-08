using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Rocksteady : Player
    {
        public Rocksteady(string name) : base(name)
        {
        }

        public override int GenerateRoshambo()
        {
            int choice = (int)Roshambo.Rock;
            return choice;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}



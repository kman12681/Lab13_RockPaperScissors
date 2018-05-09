using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class User : Player
    {
        public User(string name) : base(name)
        {
        }
        public override Roshambo GenerateRoshambo()
        {
            return Validator.UserChoice();
        }

        //public override string ToString()
        //{
        //    return base.ToString() + $"{Choice}";
        //}
    }
}

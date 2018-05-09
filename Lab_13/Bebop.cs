using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Bebop : Player
    {       
        public Bebop(string name) : base(name)
        {
        }           
       
        public override Roshambo GenerateRoshambo()
        {
            Array values = Enum.GetValues(typeof(Roshambo));
            Random random = new Random();            
            return (Roshambo)random.Next(0,3);
        }        
        
    }
}

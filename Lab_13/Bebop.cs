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

        //Roshambo randomValue = (Roshambo)values.GetValue(random.Next(values.Length));
        //int choice = random.Next(0, 3);

        //public override string ToString()
        //{
        //    return $"{name}: {GenerateRoshambo()}";
        //}

        //public Roshambo GetRandom()
        //{
        //    Array values = Enum.GetValues(typeof(Roshambo));
        //    Random random = new Random();
        //    Roshambo randomValue = (Roshambo)values.GetValue(random.Next(values.Length));
        //    //int choice = random.Next(0, 3);
        //    return randomValue;
        //}


    }

}

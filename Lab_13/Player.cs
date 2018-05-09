using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    abstract class Player
    {
        private string name;
        private Roshambo choice;

        public string Name { get => name; set => name = value; }
        public Roshambo Choice { get => choice; set => choice = value; }        

        public Player (string name)
        {
            this.Name = name;            
        }        

        public abstract Roshambo GenerateRoshambo();

        public override string ToString()
        {
             return $"{Name}: {Choice} ";
        }
    }
}



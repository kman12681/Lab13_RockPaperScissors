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
        private int choice;

        public string Name { get => name; set => name = value; }
        public int Choice { get => choice; set => choice = value; }

        public Player (string name)
        {
            Name = name;            
        }        

        public abstract int GenerateRoshambo();

        public override string ToString()
        {
            return $"{name}";
        }

    }
}



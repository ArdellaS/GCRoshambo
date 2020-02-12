using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    abstract class Player 
    {
        private string name;

        public Player(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }

        public abstract Roshambo GenerateRoshambo();
        
    }

}

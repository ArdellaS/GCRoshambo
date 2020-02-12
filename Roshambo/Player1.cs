using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    class Player1 : Player
    { 
        public Player1(string name)  
            :base(name)
        {
            name = "Glass Joe";
        }
        public override Roshambo GenerateRoshambo()
        {
            Roshambo rock = Roshambo.rock;
            return rock;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    class Player2 : Player
    {

        public Player2(string name)
            : base(name)
        {
            name = "Mike Tyson";
        }
        public override Roshambo GenerateRoshambo()
        {
            Random randomRoshamboValue = new Random();
            return (Roshambo)randomRoshamboValue.Next(0,3);
        }

    }

}


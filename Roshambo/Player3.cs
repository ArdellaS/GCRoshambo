using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roshambo
{
    class Player3 : Player
    {
        
        public Player3(string name) 
            : base(name)
        {
            Name = name;
        }

        public override Roshambo GenerateRoshambo()
        {
            Console.Write("\nRock, Paper, Scissor. Shoot! Enter your selection: ");
            Roshambo choice = Enum.Parse<Roshambo>(Validator(Console.ReadLine()));
            
            return choice;
        }
        public string Validator(string input)
        {
            string choice = "";

            while (input != "rock" && input != "paper" && input != "scissors")
            {
                Console.WriteLine("Make a valid selection: \nRock\tPaper\tScissors");
                input = Console.ReadLine();
            }
            choice = input;
            return choice;

        }
    }
}

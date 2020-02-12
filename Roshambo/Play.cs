using System;
using System.Collections.Generic;
using System.Threading;

namespace Roshambo
{
    class Play
    {

        public void Start()
        {

            string name = GetString("Enter your name: ");
            Player3 player = new Player3(name);

            do
            {
                string level = GetString($"Welcome {player.Name} would you like to play against Glass Joe or Mike Tyson?").ToLower();
                
                if (level == "glass joe" || level == "glass" | level == "joe")
                {
                    EasyMode(ref name);
                }
                else if (level == "mike tyson" || level == "mike" || level == "tyson")
                {

                    HardMode(ref name);
                }

            } while (Continue());
            Console.WriteLine("Let's play again soon!");
        }
        public void HardMode(ref string name)
        {
            Player3 player = new Player3(name);

            string input = player.GenerateRoshambo().ToString();
            Player2 comp = new Player2("Mike Tyson");

            string opponent = comp.GenerateRoshambo().ToString();

            Console.WriteLine($"\n{player.Name} chose {input}." +
            $"\n{comp.Name} chose {opponent}");

            if ((input == "rock" && opponent == "scissors") || (input == "scissors" && opponent == "paper") || (input == "paper" && opponent == "rock"))
            {
                Console.WriteLine($"\n{player.Name} wins");
            }
            else if ((opponent == "rock" && input == "scissors") || (opponent == "scissors" && input == "paper") || (opponent == "paper" && input == "rock"))
            {
                Console.WriteLine($"\n{comp.Name} wins");
            }
            else if (input == opponent)
            {
                Console.WriteLine("\nTie");
            }
        }
        public void EasyMode(ref string name)
        {
            Player3 player = new Player3(name);

            string input = player.GenerateRoshambo().ToString();
            Player1 comp = new Player1("Glass Joe");

            string opponent = comp.GenerateRoshambo().ToString();

            Console.WriteLine($"\n{player.Name} chose {input}." +
            $"\n{comp.Name} chose {opponent}");

            if (input == "paper")
            {
                Console.WriteLine($"\n{player.Name} wins");
            }
            else if (input == "scissors")
            {
                Console.WriteLine($"\n{comp.Name} wins");
            }
            else if (input == "rock")
            {
                Console.WriteLine("\nTie");
            }
        }

        public string GetString(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        static bool Continue()
        {
            char c;

            do
            {
                Console.WriteLine("\nAnother round? y/n");
                c = Console.ReadKey().KeyChar;
                if (c == 'n' || c == 'N')
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                    return false;
                }
            } while (c != 'y' && c != 'Y');

            Thread.Sleep(1000);
            Console.Clear();
            return true;

        }
    
        
    }
}

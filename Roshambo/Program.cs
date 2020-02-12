using System;

namespace Roshambo
{
    class Program
    {
        static void Main(string[] args)
        {
            Play game = new Play();
            Console.WriteLine("To play Rock, Paper, Scissors, make a selection:");
            game.Start();
        }
    }
}

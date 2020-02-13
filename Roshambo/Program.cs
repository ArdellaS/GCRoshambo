using System;

namespace Roshambo
{
    class Program
    {
        static void Main(string[] args)
        {
            Play game = new Play();
            Console.WriteLine("Before we get started, what's your name?");
            game.Start();
        }
    }
}

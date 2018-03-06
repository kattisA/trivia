using System;

namespace Trivia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Trivia!");
			Console.WriteLine("What's your name?");
			string name = Console.ReadLine();

			Player player = new Player(name);
			Console.WriteLine("Hello " + player.Name);
			Console.ReadKey();

		}
    }
}

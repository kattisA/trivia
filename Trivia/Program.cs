using System;

namespace Trivia
{
    class Program
    {
        static void Main(string[] args)
        {
			Logic logic = new Logic();
			int userInput = 0;
			Console.WriteLine("Welcome to Trivia!");
			Console.WriteLine("What's your name?");
			string name = Console.ReadLine();

			Player player = new Player(name);
			Console.WriteLine("Hello " + player.Name);

			do
			{
				userInput = Menu();
				switch (userInput)
				{
					case 1:
						Console.WriteLine("Case 1: You have chosen addition!");
						logic.playAdditionTrivia();
						break;
					case 2:
						Console.WriteLine("Case 2");
						break;
					case 3:
						Console.WriteLine("Case 3");
						break;
					case 4:
						Console.WriteLine("Case 4");
						break;
					default:
						Console.WriteLine("Please enter a correct choice");
						break;
				}
			} while (userInput != 5);

		}

		static public int Menu()
		{
			Console.WriteLine("1. Addition");
			Console.WriteLine("2. ");
			Console.WriteLine("3. ");
			Console.WriteLine("4. ");
			Console.WriteLine("5. Exit");
			var result = Console.ReadLine();
			return Convert.ToInt32(result);
		}
	}
}

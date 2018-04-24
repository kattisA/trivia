using System;
using System.Collections.Generic;
using System.Text;

namespace Trivia
{
    class TriviaIO
    {
		public static int quizLength = 3;
		static Boolean success = false;
		Logic logic = new Logic();

		public void Start() {
			
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
						Console.WriteLine("Case 1: You have chosen addition quiz!");
						int result = MakeLoop(userInput, logic);
						logic.addToScore(player, result);
						Console.WriteLine(result);
						break;
					case 2:
						Console.WriteLine("Case 2: You have chosen subtraction quiz!");
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

		public int Menu()
		{
			Console.WriteLine("1. Addition");
			Console.WriteLine("2. Subtraction ");
			Console.WriteLine("3. ");
			Console.WriteLine("4. ");
			Console.WriteLine("5. Exit");
			var result = Console.ReadLine();
			return Convert.ToInt32(result);
		}

		public int MakeLoop(int type, Logic logic)
		{
			int i = 0;
			int result = 0;
			while (i < quizLength)
			{
				success = logic.playTrivia(type);
				i++;
				if (success) { result++; }
			}
			return result;

		}
	}
}

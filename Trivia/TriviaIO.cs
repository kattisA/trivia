﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Trivia
{
    class TriviaIO
    {
		public void Start() {
			
			int userInput = 0;

			Console.WriteLine("Welcome to Trivia!");
			Console.WriteLine("Now, what's your name?");
			string name = Console.ReadLine();
			Logic logic = new Logic(new Player(name));
			Console.WriteLine("Hello " + name);
			logic.ReadFile();

			do
			{
				userInput = Menu();
				switch (userInput)
				{
					case 1:
						Console.WriteLine("Case 1: You have chosen addition quiz!");
						logic.Play(userInput);
						break;
					case 2:
						Console.WriteLine("Case 2: You have chosen subtraction quiz!");
						logic.Play(userInput);
						break;
					case 3:
						Console.WriteLine("Case 3: Mixed quiz!");
						logic.Play(userInput);
						break;
					case 4:
						Console.WriteLine("This is " + name + " scoreboard:");
						logic.PrintPlayerScores();
						break;
					case 5:
						logic.PrintAllScores();
						break;
					case 6:
						Console.WriteLine("Bye, bye " + name);
						Console.ReadKey();
						logic.WriteFile();
						break;
					default:
						Console.WriteLine("Please enter a correct choice");
						break;
				}
			} while (userInput != 6);			
		}

		public int Menu()
		{
			Console.WriteLine("1. Addition");
			Console.WriteLine("2. Subtraction");
			Console.WriteLine("3. Mixed");
			Console.WriteLine("4. Check your score");
			Console.WriteLine("5. Check all scores");
			Console.WriteLine("6. Exit");
			var result = Console.ReadLine();
			return Convert.ToInt32(result);
		}	
	}
}

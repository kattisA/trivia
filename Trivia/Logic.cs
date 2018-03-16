using System;
using System.Collections.Generic;
using System.Text;

namespace Trivia
{
    class Logic
    {
		public Logic() { }

		public int GenerateRandom() {

			Random random = new Random();
			int rand_number = random.Next(1, 11);
			return rand_number;
			
		}

		public void playAdditionTrivia() {
			int number1 = GenerateRandom();
			int number2 = GenerateRandom();

			Console.WriteLine(AdditionQuestion(number1, number2));
			string answerInput = Console.ReadLine();
			int answer = Convert.ToInt32(answerInput);
			int correct = number1 + number2;

			if (answer == correct)
			{
				Console.WriteLine("Well done");
			}
			else { Console.WriteLine("Sorry, better luck next time!"); }
		}

		public string AdditionQuestion(int num1, int num2) {
			string question = "What is " + num1 + " + " + num2 + " ?";
			return question;
		}
    }
}

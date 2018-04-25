using System;
using System.Collections.Generic;
using System.Text;

namespace Trivia
{
    class Logic
    {
		public Logic() { }
		public const int MAX_NUM = 10;
		public const int MIN_NUM = 1;
		public int GenerateRandom(int min, int max) {

			Random random = new Random();
			int rand_number = random.Next(min, max);
			return rand_number;
			
		}

		public Boolean playTrivia(int type) {
			int number1 = GenerateRandom(MIN_NUM, MAX_NUM +1);
			int number2 = GenerateRandom(MIN_NUM, MAX_NUM + 1);
			var QA = GenerateQuestion(number1, number2, type);
			Boolean success = false; 


			Console.WriteLine(QA.question);
			
			string answerInput = Console.ReadLine();
			int answer = Convert.ToInt32(answerInput);

			if (answer == QA.answer)
			{
				Console.WriteLine("Well done!");
				success = true;
				
			}
			else { Console.WriteLine("Sorry, better luck next time!"); }

			return success;
		}

		public void AddToScore(Player player, int result, int type)
		{
			string stringType = "";
			if (type == 1){
				stringType = "Addition";
			}
			if (type == 2) { stringType = "Subtraction"; }
			else { stringType = "Mixed"; }
			player.AddToScore(result, stringType);
		}

		public (string question, int answer) GenerateQuestion(int num1, int num2, int type) {
			const int MAX_TYPE = 2; 
			int correct = 0;
			string question = "";
			if (type == 3) {
				type = GenerateRandom(MIN_NUM, MAX_TYPE +1); 
			}
			if (type == 1)
			{
				question = "What is " + num1 + " + " + num2 + " ?";
				correct = num1 + num2;
			}
			if (type == 2)
			{
				question = "What is " + num1 + " - " + num2 + " ?";
				correct = num1 - num2;
			}
			return (question, correct);
		}

    }
}

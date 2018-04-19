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

		public Boolean playTrivia(int type) {
			int number1 = GenerateRandom();
			int number2 = GenerateRandom();
			var QA = GenerateQuestion(number1, number2, type);
			Boolean success = false; 


			if (type == 1) {
				Console.WriteLine(QA.question);
			}
			if (type == 2){
				Console.WriteLine(QA.question);
			}
			
			string answerInput = Console.ReadLine();
			int answer = Convert.ToInt32(answerInput);

			if (answer == QA.answer)
			{
				Console.WriteLine("Well done");
				success = true;
				
			}
			else { Console.WriteLine("Sorry, better luck next time!"); }

			return success;
		}

		public void addToScore(Player player, int resultAdd)
		{
			player.Scores.Add(resultAdd);
		}

		public (string question, int answer) GenerateQuestion(int num1, int num2, int type) {
			int correct = 0;
			string question = ""; 
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

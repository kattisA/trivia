using System;
using System.Collections.Generic;
using System.Text;

namespace Trivia
{
    class Player
    {
		public const int BASE = 100;
		private List<Score> scores = new List<Score>();
		public Player(string name) {
			Name = name;
		}

		public string Name { get; set; }
		

		public void AddToScore(int result, string type) {
			scores.Add(new Score(result, type)); 
		}

		public void PrintScores(int quizLength) {
			foreach (Score score in scores) {
				double percent = ((double)score.Correct / (double)quizLength) * BASE;
				int percentInt = Convert.ToInt32(percent); 
				Console.WriteLine("Score: " + percentInt +" % "  + "Type: " + score.Type); 
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Trivia
{
    class Player
    {
		private List<int> scores = new List<int>();
		public Player(string name) {
			Name = name;
		}

		public string Name { get; set; }
		

		public void addToScore(int result) {
			scores.Add(result); 
		}
	}
}

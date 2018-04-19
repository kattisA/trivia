using System;
using System.Collections.Generic;
using System.Text;

namespace Trivia
{
    class Player
    {
			 
		public Player(string name) {
			Name = name;
			List<int> Scores = new List<int>();
		}

		public string Name { get; set; }
		public List<int> Scores { get; set; }
	}
}

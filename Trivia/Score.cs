using System;
using System.Collections.Generic;
using System.Text;

namespace Trivia
{
    class Score
    {

		public Score(int correct, String type)
		{
			Correct = correct;
			Type = type;
		}

		public int Correct { get; private set; }
		public String Type { get; private set; }
	}
}

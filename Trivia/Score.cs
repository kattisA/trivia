using System;
using System.Collections.Generic;
using System.Text;

namespace Trivia
{
    class Score
    {

		public Score(int correct, String type, String name)
		{
            Name = name;
            Correct = correct;
			Type = type;
		}

        public string Name { get; set; }
        public int Correct { get; private set; }
		public String Type { get; private set; }
	}
}

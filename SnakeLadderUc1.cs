using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
	class SnakeLadderUc1
	{
		private static void Main(string[] args)
		{
			int position = 0;
			while (position <= 100)
			{
				Console.WriteLine("Current Position of a player = " + position);
				position++;
			}
		}
	}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitRace
{
	public static class GameBoard
	{
		public const int sizeX = 16;
		public const int sizeY = 16;

		public static void Draw()
		{
			for (int y = 0; y < sizeY; y++)
			{
				for (int x = 0; x < sizeX; x++)
				{
					if (y == 0 || y == sizeY - 1 || x == 0 || x == sizeX - 1)
					{
						Console.SetCursorPosition(x * 2, y);
						Console.Write("# ");
					}

				}
				Console.WriteLine();
			}
			DrawPositions();
		}

		private static void DrawPositions()
		{
			var tupleList = new List<Tuple<int, int>>
			{
				Tuple.Create( 2, 11 ),
				Tuple.Create( 2, 9 ),
				Tuple.Create( 2, 7 ),
				Tuple.Create( 3, 5 ),
				Tuple.Create( 5, 3 ),
				Tuple.Create( 7, 2 ),
				Tuple.Create( 9, 2 ),
				Tuple.Create( 11, 2 ),
				Tuple.Create( 12, 3 ),
				Tuple.Create( 13, 5 ),
				Tuple.Create( 13, 7 ),
				Tuple.Create( 13, 9 ),
				Tuple.Create( 12, 11 ),
				Tuple.Create( 13, 9 ),
				Tuple.Create( 12, 11 ),
				Tuple.Create( 10, 12 ),
				Tuple.Create( 8, 12 ),
				Tuple.Create( 6, 11 ),
				Tuple.Create( 4, 10 ),
				Tuple.Create( 5, 8 ),
				Tuple.Create( 7, 9 ),
				Tuple.Create( 9, 9 ),
				Tuple.Create( 11, 8 ),
				Tuple.Create( 11, 6 ),
				Tuple.Create( 10, 5 ),
				Tuple.Create( 8, 4 ),
				Tuple.Create( 6, 5 ),
				Tuple.Create( 7, 6 ),
			};

			foreach (var tuple in tupleList)
			{
				Console.SetCursorPosition(tuple.Item1 * 2, tuple.Item2);
				Console.Write("O ");
			}
			Console.SetCursorPosition(16, 7);
			Console.Write("[");
			Console.SetCursorPosition(17, 7);
			Console.Write("]");

		}
	}
}

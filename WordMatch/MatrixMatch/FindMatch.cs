using System;
using System.Collections.Generic;
using System.Linq;
namespace Match
{
	public class FindMatch
	{
		public static List<(int Row, int Col)> GetMatches(char[][] matrix, char target)
		{
			return matrix
				.SelectMany((row, rowIndex) =>
					row.Select((ch, colIndex) => new { ch, rowIndex, colIndex }))
				.Where(x => x.ch == target)
				.Select(x => (x.rowIndex, x.colIndex)).ToList();
		}

		public static bool IsAdjacent((int Row, int Col) a, (int Row, int Col) b)
		{
			int dr = Math.Abs(a.Row - b.Row);
			int dc = Math.Abs(a.Col - b.Col);
			return dr + dc == 1;
		}

		public static bool Find(char[][] matrix, ReadOnlySpan<char> word)
		{
			if(word.Length == 0) return false;

			List<(int Row, int Col)> currentPositions = GetMatches(matrix, word[0]);

			for(int i = 1; i < word.Length; i++)
			{
				var nextChar = word[i];
				var nextPositions = GetMatches(matrix, nextChar);

				var prevPositions = currentPositions;

				var filtered = new List<(int Row, int Col)>();

				foreach(var pos in nextPositions)
				{
					foreach(var prev in prevPositions)
					{
						if(IsAdjacent(prev, pos))
						{
							filtered.Add(pos);
							break;
						}
					}
				}

				currentPositions = filtered;

				if(!currentPositions.Any())
					return false;
			}

			return true;
		}
	}
}
namespace Match
{
	class Match
	{
		
		public static void Main(string[] args)
		{
			char[][] board = {
			 ['A','B','C','E'],
			 ['S','F','C','S'],
			 ['A','D','E','E']
			};
			string word = "ABCCED";
			bool result = FindMatch.Find(board, word.AsSpan());
			Console.WriteLine(result);
		}
	}
}
namespace Match
{
	class Match
	{
		/*
		 Problem Statement:
		 Given a 2D grid of characters and a word, return true if the word exists in the grid. 
		 The word can be constructed from letters of sequentially adjacent cells (horizontally or vertically and in any direction – forward or backward).

 

   	   Sample Input:

   	   char[][] board = {
      	   ['A','B','C','E'],
      	   ['S','F','C','S'],
      	   ['A','D','E','E']
    		};
   	   string word = "ABCCED";

 

  			Sample Output: true

    	 */
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
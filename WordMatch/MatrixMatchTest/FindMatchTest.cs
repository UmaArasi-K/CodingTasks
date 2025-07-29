using Match;
namespace MatchTest
{
	[TestClass]
	public sealed class FindMatchTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			//Arrange

			char[][] board = {
			 ['A','B','C','E'],
			 ['S','F','C','S'],
			 ['A','D','E','E']
			};
			string word = "ABCCED";

			//Act
			bool result = FindMatch.Find(board, word.AsSpan());

			//Assert
			Assert.AreEqual(true, result);
		}

		[TestMethod]
		public void TestMethod2()
		{
			//Arrange

			char[][] board = {
			 ['A','B','C','E'],
			 ['S','F','C','S'],
			 ['A','D','E','E']
			};
			string word = "ABCCEDB";

			//Act
			bool result = FindMatch.Find(board, word.AsSpan());

			//Assert
			Assert.AreEqual(false, result);
		}
		[TestMethod]
		public void TestMethod3()
		{
			//Arrange

			char[][] board = {
			 ['A','B','C','E'],
			 ['S','F','C','S'],
			 ['A','D','E','E']
			};
			string word = "ABABC";

			//Act
			bool result = FindMatch.Find(board, word.AsSpan());

			//Assert
			Assert.AreEqual(true, result);
		}
	}
}

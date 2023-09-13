using CSharpIteration.Classes;

namespace CSharpIteration.Tests
{
	[TestClass]
	public class IterationExamplesTests
	{

		[TestClass]
		public class IterationExampleTests
		{
			[TestMethod]
			[DataRow(-1, 0)]
			[DataRow(10, 55)]
			[DataRow(100, 5050)]
			public void TestSumOfNNumbers(int input, int expectedValue)
			{
				int total = IterationExamples.Sum(input);
				Assert.AreEqual(expectedValue, total);
			}

			[TestMethod]
			public void TestSquaredNumbers()
			{
				List<double> input = new() { 0.5, 4, 0.25, 1, 2, -3 };
				List<double> expected = new() { 0.25, 16, 0.0625, 1, 4, 9 };
				List<double> squaredNumbers = IterationExamples.SquaredNumbers(input);
				CollectionAssert.AreEqual(expected, squaredNumbers);
			}

			[TestMethod]
			public void TestFindTotalTestScore()
			{
				List<List<int>> input = new()
				{
					new() { 1, 3, 5, 7, 9 },
					new() { 0, 2, 4, 6 },
					new() { 11, 22 }
				};
				List<int> expected = new() { 25, 12, 33 };
				List<int> testScores = IterationExamples.FindTotalTestScore(input);
				CollectionAssert.AreEqual(expected, testScores);
			}
		}
	}
}
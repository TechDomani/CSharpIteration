using CSharpIteration.Classes;
using System.Diagnostics;

namespace CSharpIteration
{
	internal class Program
	{
		static void Main()
		{
			string greeting = IterationExamples.BirthdayGreeting();
			Console.WriteLine(greeting);

			int sum = IterationExamples.SumNumbers();
			Console.WriteLine(sum);

			// To save commenting and uncommenting our code and to help test different cases we can use Debug.Assert            
			// Testing Sum            
			Debug.Assert(IterationExamples.Sum(-1) == 0, "$Output unexpected");
			Debug.Assert(IterationExamples.Sum(10) == 55);
			Debug.Assert(IterationExamples.Sum(100) == 5050);

			List<double> numbers = new() { 9, 12, 3, 7, 17 };
			List<double> squareNumbers = IterationExamples.SquaredNumbers(numbers);
			string squareNumbersOutput = string.Join(", ", squareNumbers);
			Console.WriteLine(squareNumbersOutput);

			IterationExamples.CakesEaten(10);

			IterationExamples.ValidateNumberEntry();

			List<List<int>> testScores = new()
			{
				new() { 1, 3, 5, 7, 9 },
				new() { 0, 2, 4, 6 },
				new() { 11, 22 }
			};
			List<int> totalTestScores = IterationExamples.FindTotalTestScore(testScores);
			string totalTestScoreOutput = string.Join(", ", totalTestScores);
			Console.WriteLine($"Total test scores are {totalTestScoreOutput}");
		}
	}
}
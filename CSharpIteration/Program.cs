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

		    Console.WriteLine(IterationExamples.Sum(-1));
			Console.WriteLine(IterationExamples.Sum(10));
			Console.WriteLine(IterationExamples.Sum(100));

			List<double> numbers = [ 9, 12, 3, 7, 17 ];
			List<double> squareNumbers = IterationExamples.SquaredNumbers(numbers);
			string squareNumbersOutput = string.Join(", ", squareNumbers);
			Console.WriteLine(squareNumbersOutput);

			IterationExamples.CakesEaten(10);

			IterationExamples.ValidateNumberEntry();

			List<List<int>> testScores = 
			[
				[ 1, 3, 5, 7, 9 ],
				[ 0, 2, 4, 6 ],
				[ 11, 22 ]
			];
			List<int> totalTestScores = IterationExamples.FindTotalTestScore(testScores);
			string totalTestScoreOutput = string.Join(", ", totalTestScores);
			Console.WriteLine($"Total test scores are {totalTestScoreOutput}");
		}
	}
}
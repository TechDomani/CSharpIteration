namespace CSharpIteration.Classes
{
	public static class IterationExamples
	{
		#region Count controlled 
		// In Count controlled or definite iteration
		// The statement is repeated a specific number of times

		// Basic for loop
		public static int Sum(int n)
		{
			int total = 0;
			for (int i = 0; i <= n; i++)
			{
				total += i;
			}
			return total;
		}

		// For each example with int list
		public static int SumNumbers()
		{
			List<int> numbers = [ 5, 2, 3, 6, 7, 8 ];
			int total = 0;
			foreach (int num in numbers)
			{
				total += num;
			}
			return total;
		}

		// For each example with string list
		public static string BirthdayGreeting()
		{
			List<string> names = [ "Bob", "Jane", "Kevin", "Fred" ];
			string greeting = "Happy birthday to ";
			foreach (string item in names)
			{
				greeting = greeting + $"{item} ";
			}
			return greeting;
		}

		// For loop versus a foreach loop
		// In a foreach loop the loop variable is read only and cannot be changed
		public static List<double> SquaredNumbers(List<double> numbers)
		{
			for (int i = 0; i < numbers.Count; i++)
			{
				numbers[i] = Math.Pow(numbers[i], 2);
			}
			return numbers;
		}

		//public static List<double> SquaredNumbersUsingForEach(List<double> numbers)
		//{
		//	foreach (double num in numbers)
		//	{
		//		num = Math.Pow(num, 2);
		//	}
		//	return numbers;
		//}

		// Nested for loop
		public static List<int> FindTotalTestScore(List<List<int>> testScores)
		{
			List<int> totalScores = new();
			for (int i = 0; i < testScores.Count; i++)
			{
				totalScores.Add(0);
				for (int j = 0; j < testScores[i].Count; j++)
				{
					totalScores[i] += testScores[i][j];
				}
			}
			return totalScores;
		}
		#endregion

		#region Condition Controlled
		public static void CakesEaten(int cakeNumber)
		{
			while (cakeNumber > 0)
			{
				Console.WriteLine($"{cakeNumber} cakes");
				cakeNumber--;
			}
			Console.WriteLine("No cakes left");
		}

		// Please note that user input really should not be taken from a subprogram in a class library
		// However, I wanted to give an example of where you might use a do-while loop whilst keeping all the example code together.
		public static void ValidateNumberEntry()
		{
			int numberEntered = 0;
			do
			{
				Console.WriteLine($"Please enter a whole number between 1 and 50");
				string value = Console.ReadLine() ?? "";
				if (int.TryParse(value, out int number))
				{
					numberEntered = number;
				}

			} while (numberEntered < 1 || numberEntered > 50);
			Console.WriteLine($"You entered {numberEntered}");
		}
		#endregion
	}
}
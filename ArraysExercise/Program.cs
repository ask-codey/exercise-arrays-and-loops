using ArraysExercise;

// Try your methods here. Change the values and run the program
// (dotnet run, or Ctrl+F5 in Visual Studio) to see what they return.
// The tests in ArraysExercise.Tests check every method for you.

string[] week = Calendar.DaysOfTheWeek();
Console.WriteLine("Days in a week: " + week.Length);

int[] scores = { 21, 14, 35, 28 };
Console.WriteLine("Total points: " + NumberLists.SumNumbers(scores));

decimal[] cart = { 12.75m, 10.25m, 8.44m, 9.20m };
Console.WriteLine("Highest price: $" + Prices.HighestPrice(cart));

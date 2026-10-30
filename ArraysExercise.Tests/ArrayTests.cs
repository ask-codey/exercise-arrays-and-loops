using ArraysExercise;

namespace ArraysExercise.Tests;

// Each test calls one of your methods and checks what it returns.
// You don't need to change this file.

[TestClass]
public class CalendarTests
{
    static readonly string[] FullWeek = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
    static readonly string[] WorkWeek = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday"];

    [TestMethod]
    public void DaysOfTheWeek()
    {
        string[] actual = Calendar.DaysOfTheWeek();

        Assert.HasCount(7, actual, "A week has 7 days.");
        CollectionAssert.AreEqual(FullWeek, actual, "The days start with Sunday and are in order.");
    }

    [TestMethod]
    public void MonthsOfTheYear()
    {
        string[] expected = ["January", "February", "March", "April", "May", "June",
                             "July", "August", "September", "October", "November", "December"];

        string[] actual = Calendar.MonthsOfTheYear();

        Assert.HasCount(12, actual, "A year has 12 months.");
        CollectionAssert.AreEqual(expected, actual, "The months start with January and are in order.");
    }

    [TestMethod]
    public void FirstDayOfWeek()
    {
        Assert.AreEqual("Sunday", Calendar.FirstDayOfWeek(FullWeek), "A full week starts on Sunday.");
        Assert.AreEqual("Monday", Calendar.FirstDayOfWeek(WorkWeek), "A work week starts on Monday.");
    }

    [TestMethod]
    public void LastDayOfWeek()
    {
        Assert.AreEqual("Saturday", Calendar.LastDayOfWeek(FullWeek), "A full week ends on Saturday.");
        Assert.AreEqual("Friday", Calendar.LastDayOfWeek(WorkWeek), "A work week ends on Friday.");
    }

    [TestMethod]
    [DataRow(1, "Jan")]
    [DataRow(2, "Feb")]
    [DataRow(8, "Aug")]
    [DataRow(12, "Dec")]
    public void MonthName(int monthNumber, string expected)
    {
        string[] months = ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];

        string actual = Calendar.MonthName(months, monthNumber);

        Assert.AreEqual(expected, actual, $"Month number {monthNumber} is {expected}.");
    }
}

[TestClass]
public class NumberListsTests
{
    [TestMethod]
    public void OneToFifty()
    {
        int[] actual = NumberLists.OneToFifty();

        Assert.HasCount(50, actual, "The array holds 50 numbers.");
        for (int i = 0; i < actual.Length; i++)
        {
            Assert.AreEqual(i + 1, actual[i], $"The number at index {i} is {i + 1}.");
        }
    }

    [TestMethod]
    public void EvenNumbers()
    {
        int[] actual = NumberLists.EvenNumbers();

        Assert.HasCount(100, actual, "There are 100 even numbers from 2 to 200.");
        for (int i = 0; i < actual.Length; i++)
        {
            Assert.AreEqual((i + 1) * 2, actual[i], $"The number at index {i} is {(i + 1) * 2}.");
        }
    }

    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, 10)]
    [DataRow(new[] { 1, 3, 5 }, 9)]
    [DataRow(new[] { 1, 1, 2, 3 }, 7)]
    public void SumNumbers(int[] numbers, int expected)
    {
        int actual = NumberLists.SumNumbers(numbers);

        Assert.AreEqual(expected, actual, $"[{string.Join(", ", numbers)}] adds up to {expected}.");
    }

    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, 12)]
    [DataRow(new[] { 10, 11, 13 }, 20)]
    [DataRow(new[] { 1, 3, 5 }, 0)]
    public void DoubleEvens(int[] numbers, int expected)
    {
        int actual = NumberLists.DoubleEvens(numbers);

        Assert.AreEqual(expected, actual, $"The even numbers in [{string.Join(", ", numbers)}], doubled, are {expected}.");
    }

    [TestMethod]
    [DataRow(new[] { 1, 2, 3, 4 }, 5)]
    [DataRow(new[] { 1, 3, 5 }, 1)]
    [DataRow(new[] { 1, 1, 2, 3, 5, 8, 13 }, 17)]
    public void SumEveryThird(int[] numbers, int expected)
    {
        int actual = NumberLists.SumEveryThird(numbers);

        Assert.AreEqual(expected, actual, $"Every third number of [{string.Join(", ", numbers)}] adds up to {expected}.");
    }

    [TestMethod]
    [DataRow(new[] { 1, 2, 3 }, 3)]
    [DataRow(new[] { 10, 8, 14, 32 }, 18)]
    [DataRow(new[] { 7 }, 7)]
    [DataRow(new int[0], 0)]
    public void SumFirstTwoNumbers(int[] numbers, int expected)
    {
        int actual = NumberLists.SumFirstTwoNumbers(numbers);

        Assert.AreEqual(expected, actual, $"The first two numbers of [{string.Join(", ", numbers)}] add up to {expected}.");
    }
}

[TestClass]
public class NamesTests
{
    static readonly string[] Team = ["Ron", "Lisa", "Kent", "Michelle"];
    static readonly string[] Signups = ["Ron", "Michelle", "Lisa", "Kent", "Michelle"];

    [TestMethod]
    [DataRow("Kent", true)]
    [DataRow("kent", true)]
    [DataRow("RON", true)]
    [DataRow("Jenny", false)]
    public void HasName(string nameToFind, bool expected)
    {
        bool actual = Names.HasName(Team, nameToFind);

        Assert.AreEqual(expected, actual, $"Searching [Ron, Lisa, Kent, Michelle] for \"{nameToFind}\" gives {expected}.");
    }

    [TestMethod]
    [DataRow("Ron", 1)]
    [DataRow("michelle", 2)]
    [DataRow("Jenny", 0)]
    public void CountName(string nameToFind, int expected)
    {
        int actual = Names.CountName(Signups, nameToFind);

        Assert.AreEqual(expected, actual, $"\"{nameToFind}\" is in [Ron, Michelle, Lisa, Kent, Michelle] {expected} time(s).");
    }

    [TestMethod]
    public void ReverseNames()
    {
        string[] names = ["Ron", "Lisa", "Kent", "Michelle"];

        string[] actual = Names.ReverseNames(names);

        CollectionAssert.AreEqual(new[] { "Michelle", "Kent", "Lisa", "Ron" }, actual, "The names are in reverse order.");
        CollectionAssert.AreEqual(new[] { "Ron", "Lisa", "Kent", "Michelle" }, names, "The array you were given is unchanged.");
    }
}

[TestClass]
public class PricesTests
{
    [TestMethod]
    [DataRow(new[] { 12.75, 10.25, 8.44, 9.20 }, 10.16)]
    [DataRow(new[] { 15.25, 2.34, 3.50 }, 7.03)]
    public void AveragePrice(double[] values, double expected)
    {
        decimal actual = Prices.AveragePrice(ToDecimals(values));

        Assert.AreEqual((decimal)expected, actual, $"The average of [{string.Join(", ", values)}] is {expected}.");
    }

    [TestMethod]
    [DataRow(new[] { 12.75, 10.25, 8.44, 9.20 }, 12.75)]
    [DataRow(new[] { 15.25, 21.34, 3.50 }, 21.34)]
    public void HighestPrice(double[] values, double expected)
    {
        decimal actual = Prices.HighestPrice(ToDecimals(values));

        Assert.AreEqual((decimal)expected, actual, $"The highest of [{string.Join(", ", values)}] is {expected}.");
    }

    [TestMethod]
    [DataRow(new[] { -15.25, 15.25, 2.34, 3.50 }, 2.34)]
    [DataRow(new[] { 12.75, -5.50, 10.25, 18.44, 4.23, -15.55, 9.20 }, 4.23)]
    public void LowestPrice(double[] values, double expected)
    {
        decimal actual = Prices.LowestPrice(ToDecimals(values));

        Assert.AreEqual((decimal)expected, actual, $"The lowest price above 0 in [{string.Join(", ", values)}] is {expected}.");
    }

    // Attributes can't hold decimal values, so the prices are written as doubles and turned into decimals here.
    static decimal[] ToDecimals(double[] values)
    {
        decimal[] prices = new decimal[values.Length];
        for (int i = 0; i < values.Length; i++)
        {
            prices[i] = (decimal)values[i];
        }
        return prices;
    }
}

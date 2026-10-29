# Practice: Arrays and Loops

Practice code for the lesson **Practice: Arrays and Loops** in the C# Full-Stack Bootcamp on [ask-codey.com](https://www.ask-codey.com).

Seventeen small problems with arrays, in four classes in the `ArraysPractice` project:

- `Calendar.cs`: days of the week and months of the year
- `NumberLists.cs`: filling arrays with numbers, and adding them up in different ways
- `Names.cs`: searching, counting and reversing names
- `Prices.cs`: average, highest and lowest prices

Every method returns an empty array, `0`, `""` or `false` for now. The comment above each method says what it should return, with examples. Replace the `return` line with your own code.

## Run it

```bash
dotnet run --project ArraysPractice
```

In Visual Studio, open `ArraysPractice.slnx` and press **Ctrl+F5**. `Program.cs` calls a few of your methods, so you can try them out.

## Check your work

```bash
dotnet test
```

In Visual Studio, use **Test > Run All Tests**.

At first almost every test fails: that is expected. Each method you finish turns its tests green. A failing test's message says which values it used and what it expected.

## Tips

- Decide first: do you need the index (`for`), or just each element (`foreach`)?
- Indexes go from `0` to `Length - 1`. Check your loop's condition for an off-by-one mistake.
- For a total, start at 0 and add each element. For a highest or lowest, start with an element from the array and replace it when you find a better one. For `LowestPrice`, skip the refunds first: start with the first price above 0.

﻿using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode.Test.Solutions;

public abstract class YearTests
{
    private const string Prefix = "Day";

    private readonly ITestOutputHelper _testOutputHelper;
    private readonly int _year;

    protected YearTests(int year, ITestOutputHelper testOutputHelper)
    {
        _year = year;
        _testOutputHelper = testOutputHelper;
    }
    
    protected void AssertDay(string expectedA, string expectedB, [CallerMemberName] string callerName = "")
    {
        string day = callerName.Substring(Prefix.Length);
        int dayNumber = int.Parse(day);
        List<Solution> daySolutions = DayGenerator.GetSolutionsByDay(_year, dayNumber).ToList();
        Assert.NotEmpty(daySolutions);
        foreach (Solution daySolution in daySolutions)
        {
            string className = daySolution.GetType().Name;
            _testOutputHelper.WriteLine($"Found solution: {className}");
            string solution = daySolution.Run();
            if (string.IsNullOrEmpty(expectedB))
            {
                Assert.Equal(expectedA, solution.Trim('\n'));
            }
            else
            {
                Assert.Equal(expectedA + "\n" + expectedB, solution);
            }
        }
    }
}
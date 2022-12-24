using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xunit;

namespace AdventOfCode.Test;

public class Year2022DaySolutionTest
{
    private const string Prefix = "Day";
    private const string Year = "Year2022";
    
    [Fact] public void Day01() => AssertDay("70369", "203002");
    [Fact] public void Day02() => AssertDay("11449", "13187");
    [Fact] public void Day03() => AssertDay("7908", "2838");
    [Fact] public void Day04() => AssertDay("503", "827");
    [Fact] public void Day05() => AssertDay("TQRFCBSJJ", "RMHFJNVFP");
    [Fact] public void Day06() => AssertDay("1920", "2334");
    [Fact] public void Day07() => AssertDay("1644735", "1300850");
    [Fact] public void Day07B() => AssertDay("1644735", "1300850");
    [Fact] public void Day08() => AssertDay("1792", "334880");
    [Fact] public void Day09() => AssertDay("6181", "2386");
    [Fact] public void Day10() => AssertDay("13440", """
    ███  ███  ████  ██  ███   ██  ████  ██  
    █  █ █  █    █ █  █ █  █ █  █    █ █  █ 
    █  █ ███    █  █    █  █ █  █   █  █  █ 
    ███  █  █  █   █ ██ ███  ████  █   ████ 
    █    █  █ █    █  █ █ █  █  █ █    █  █ 
    █    ███  ████  ███ █  █ █  █ ████ █  █ 
    
    """);
    [Fact] public void Day11() => AssertDay("182293", "54832778815");
    [Fact] public void Day12() => AssertDay("380", "375");
    [Fact] public void Day13() => AssertDay("5806", "23600");
    [Fact] public void Day14() => AssertDay("1003", "25771");
    [Fact] public void Day15() => AssertDay("5112034", "13172087230812");
    [Fact] public void Day16() => AssertDay("1728", "2304");
    [Fact] public void Day17() => AssertDay("3065", "1562536022966");
    [Fact] public void Day18() => AssertDay("4548", "2588");
    [Fact] public void Day19() => AssertDay("1418", "4114");
    [Fact] public void Day20() => AssertDay("4224", "861907680486");
    [Fact] public void Day21() => AssertDay("83056452926300", "3469704905529");
    [Fact] public void Day22() => AssertDay("43466", "162155");
    [Fact] public void Day23() => AssertDay("3766", "954");
    [Fact] public void Day24() => AssertDay("242", "720");
    
    private void AssertDay(string expectedA, string expectedB, [CallerMemberName] string callerName = "")
    {
        string day = callerName.Substring(Prefix.Length);
        string solutionName = $"Solution{day}";
        Solution current = DayGenerator.GetByName(solutionName, Year);
        var solution = current.Run();
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
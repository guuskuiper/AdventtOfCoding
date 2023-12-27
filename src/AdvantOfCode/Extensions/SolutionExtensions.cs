﻿using System.Reflection;
using System.Runtime.CompilerServices;

namespace AdventOfCode.Extensions;

public static class SolutionExtensions
{
    public static string[] ReadLines(this Solution solution, StringSplitOptions options = StringSplitOptions.RemoveEmptyEntries, [CallerFilePath] string path = "")
    {
        string inputPath = path.Replace("Solution", "input").Replace(".cs", ".txt");

        DayInfoAttribute? dayInfo = GetDayInfo(solution);
        ArgumentNullException.ThrowIfNull(dayInfo, "No DayInfo attribute found on solution");

        string inputFileName = $"input{dayInfo.Day:D2}.txt";

        string root = RelativeToRoot(path);
        string relativePath = Path.Combine(root, "input", dayInfo.Year.ToString(), inputFileName);
        string newInputPath = Path.Combine(Path.GetDirectoryName(path)!, relativePath);
        string file = InputReader.ReadFile(dayInfo.Year, dayInfo.Day, newInputPath);
        
        if (!File.Exists(inputPath))
        {
            File.CreateSymbolicLink(inputPath, relativePath);
        }

        return file
            .ReplaceLineEndings()
            .Split(Environment.NewLine, options);
    }
    
    private static DayInfoAttribute? GetDayInfo(this Solution solution) =>
        solution.GetType().GetCustomAttribute<DayInfoAttribute>();

    private static string RelativeToRoot(string fromPath)
    {
        var directoryInfo = Directory.GetParent(fromPath);
        int up = 1;
        while (directoryInfo!.Name != "src")
        {
            up++;
            directoryInfo = directoryInfo.Parent;
        }
        return Path.Combine(Enumerable.Repeat("..", up).ToArray());
    }
}
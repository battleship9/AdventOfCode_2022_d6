using System.Text.RegularExpressions;

string rawData = File.ReadAllText("rawData.txt");

Match match = Regex.Match(rawData, @"(([a-z])(?!(?:\2[a-z]{2}|[a-z]{1}\2[a-z]{1}|[a-z]{2}\2))([a-z])(?!(?:\3[a-z]{1}|[a-z]{1}\3))([a-z])(?!(?:\4))([a-z]))");

Console.WriteLine(match.Index + 4);
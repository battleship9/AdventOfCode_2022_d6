using System.Text.RegularExpressions;

string rawData = File.ReadAllText("rawData.txt");

Match match = Regex.Match(rawData, @"(([a-z])(?!(?:[a-z]{0,2}\2[a-z]{0,2}))([a-z])(?!(?:[a-z]{0,2}\3[a-z]{0,2}))([a-z])(?!(?:[a-z]{0,2}\4[a-z]{0,2}))([a-z])(?!(?:[a-z]{0,2}\5[a-z]{0,2})))");

Console.WriteLine(match.Index + 4);
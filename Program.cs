using System.Text.RegularExpressions;

string rawData = File.ReadAllText("rawData.txt");

Match match = Regex.Match(rawData, @"(([a-z])(?!(?:[a-z]{0,6}\2[a-z]{0,6}))([a-z])(?!(?:[a-z]{0,6}\3[a-z]{0,6}))([a-z])(?!(?:[a-z]{0,6}\4[a-z]{0,6}))([a-z])(?!(?:[a-z]{0,6}\5[a-z]{0,6}))([a-z])(?!(?:[a-z]{0,6}\6[a-z]{0,6}))([a-z])(?!(?:[a-z]{0,6}\7[a-z]{0,6}))([a-z])(?!(?:[a-z]{0,6}\8[a-z]{0,6}))([a-z])(?!(?:[a-z]{0,6}\9[a-z]{0,6}))([a-z])(?!(?:[a-z]{0,6}\10[a-z]{0,6}))([a-z])(?!(?:[a-z]{0,6}\11[a-z]{0,6}))([a-z])(?!(?:[a-z]{0,6}\12[a-z]{0,6}))([a-z])(?!(?:[a-z]{0,6}\13[a-z]{0,6}))([a-z])(?!(?:[a-z]{0,6}\15[a-z]{0,6}))([a-z])(?!(?:[a-z]{0,6}\15[a-z]{0,6})))");

Console.WriteLine(match.Index + 14);
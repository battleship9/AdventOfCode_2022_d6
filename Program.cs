﻿using System.Text.RegularExpressions;

string rawData = File.ReadAllText("rawData.txt");

Match match = Regex.Match(rawData, @"(([a-z])(?!(?:\2[a-z]{12}|[a-z]{1}\2[a-z]{11}|[a-z]{2}\2[a-z]{10}|[a-z]{3}\2[a-z]{9}|[a-z]{4}\2[a-z]{8}|[a-z]{5}\2[a-z]{7}|[a-z]{6}\2[a-z]{6}|[a-z]{7}\2[a-z]{5}|[a-z]{8}\2[a-z]{4}|[a-z]{9}\2[a-z]{3}|[a-z]{10}\2[a-z]{2}|[a-z]{11}\2[a-z]{1}|[a-z]{12}\2))([a-z])(?!(?:\3[a-z]{11}|[a-z]{1}\3[a-z]{10}|[a-z]{2}\3[a-z]{9}|[a-z]{3}\3[a-z]{8}|[a-z]{4}\3[a-z]{7}|[a-z]{5}\3[a-z]{6}|[a-z]{6}\3[a-z]{5}|[a-z]{7}\3[a-z]{4}|[a-z]{8}\3[a-z]{3}|[a-z]{9}\3[a-z]{2}|[a-z]{10}\3[a-z]{1}|[a-z]{11}\3))([a-z])(?!(?:\4[a-z]{10}|[a-z]{1}\4[a-z]{9}|[a-z]{2}\4[a-z]{8}|[a-z]{3}\4[a-z]{7}|[a-z]{4}\4[a-z]{6}|[a-z]{5}\4[a-z]{5}|[a-z]{6}\4[a-z]{4}|[a-z]{7}\4[a-z]{3}|[a-z]{8}\4[a-z]{2}|[a-z]{9}\4[a-z]{1}|[a-z]{10}\4))([a-z])(?!(?:\5[a-z]{9}|[a-z]{1}\5[a-z]{8}|[a-z]{2}\5[a-z]{7}|[a-z]{3}\5[a-z]{6}|[a-z]{4}\5[a-z]{5}|[a-z]{5}\5[a-z]{4}|[a-z]{6}\5[a-z]{3}|[a-z]{7}\5[a-z]{2}|[a-z]{8}\5[a-z]{1}|[a-z]{9}\5))([a-z])(?!(?:\6[a-z]{8}|[a-z]{1}\6[a-z]{7}|[a-z]{2}\6[a-z]{6}|[a-z]{3}\6[a-z]{5}|[a-z]{4}\6[a-z]{4}|[a-z]{5}\6[a-z]{3}|[a-z]{6}\6[a-z]{2}|[a-z]{7}\6[a-z]{1}|[a-z]{8}\6))([a-z])(?!(?:\7[a-z]{7}|[a-z]{1}\7[a-z]{6}|[a-z]{2}\7[a-z]{5}|[a-z]{3}\7[a-z]{4}|[a-z]{4}\7[a-z]{3}|[a-z]{5}\7[a-z]{2}|[a-z]{6}\7[a-z]{1}|[a-z]{7}\7))([a-z])(?!(?:\8[a-z]{6}|[a-z]{1}\8[a-z]{5}|[a-z]{2}\8[a-z]{4}|[a-z]{3}\8[a-z]{3}|[a-z]{4}\8[a-z]{2}|[a-z]{5}\8[a-z]{1}|[a-z]{6}\8))([a-z])(?!(?:\9[a-z]{5}|[a-z]{1}\9[a-z]{4}|[a-z]{2}\9[a-z]{3}|[a-z]{3}\9[a-z]{2}|[a-z]{4}\9[a-z]{1}|[a-z]{5}\9))([a-z])(?!(?:\10[a-z]{4}|[a-z]{1}\10[a-z]{3}|[a-z]{2}\10[a-z]{2}|[a-z]{3}\10[a-z]{1}|[a-z]{4}\10))([a-z])(?!(?:\11[a-z]{3}|[a-z]{1}\11[a-z]{2}|[a-z]{2}\11[a-z]{1}|[a-z]{3}\11))([a-z])(?!(?:\12[a-z]{2}|[a-z]{1}\12[a-z]{1}|[a-z]{2}\12))([a-z])(?!(?:\13[a-z]{1}|[a-z]{1}\13))([a-z])(?!(?:\14))([a-z]))");

Console.WriteLine(match.Index + 14);
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//string a = "14212";
string a = "12821";
//string a = "23432";

char[] x = a.ToCharArray();
Array.Reverse(x);
string b = string.Join("", x);
System.Console.WriteLine($"value: {a == b}");

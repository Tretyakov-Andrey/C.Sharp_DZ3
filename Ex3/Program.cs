// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int n = new Random().Next (3, 20);
System.Console.WriteLine("N = " + n);
int x = 1;

while (x != n+1)
{
    System.Console.Write(x*x*x + " | ");
    x++;
}

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введи число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;

while (a <= n)
{
int result = a*a*a;
a ++;
Console.Write($"{result}, ");
}



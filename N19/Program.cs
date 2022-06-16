// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введи число:");
string number = Console.ReadLine();
int count = 0;

for 
(int i = 0; 
i < number.Length / 2; 
i++) 
{
    if(number.Substring(i, 1) != (number.Substring(number.Length - 1 - i, 1)))
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
    else count = 1;
}
if(count == 1)
Console.WriteLine($"Число {number} является палиндромом");

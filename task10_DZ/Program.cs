// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите три числа");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int a = number / 10;
    int b = a % 10;
    Console.WriteLine("Это вторая цифра числа = " + b);
}
else
{
    Console.WriteLine("Неверный ввод.");
}

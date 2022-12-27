// Задача 23. ДЗ. Напишите программу, которая принимает на вход число (N) и выдает
// таблицу кубов чисел от 1 до N?
// 3 -> 1, 8, 27.
// 5 -> 1, 8, 2, 7, 64, 125.

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"{i} * {i} * {i} = {Math.Pow(i, 3)}");
}


// Задача 13: Напишите программу, которая с помощью деления выводит
// третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 326743 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string index_number = Convert.ToString(number);
if (index_number.Length > 2)
{
    Console.WriteLine("Это третья цифра числа = " + index_number[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет.");
}
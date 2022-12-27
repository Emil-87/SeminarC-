// Задача 19 ДЗ.
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number = 23432;
int palindrom_number = number;
int result = 0;
while (palindrom_number > 0)
{
    int digit = palindrom_number % 10;
    result = result * 10 + digit;
    palindrom_number /= 10;
    Console.WriteLine(result);
}
if (result == number)
{
    Console.WriteLine($"Число: {number} палиндром.");
}
else
{
    Console.WriteLine($"Число: {number} не палиндром.");
}

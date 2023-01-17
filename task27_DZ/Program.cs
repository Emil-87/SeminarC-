//  Напишите программу, которая принимает на вход число и выдает сумму цифр в числе?

int number = 000654;
int sum = 0;
while (number > 0) 
{
    sum += number % 10;
    number /= 10;
}
Console.WriteLine($"Сумма чисел равна: {sum}");
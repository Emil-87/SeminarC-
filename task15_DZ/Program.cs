// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

void task15()
{
    Console.WriteLine("Введите день недели: ");

    int a = Convert.ToInt32(Console.ReadLine());
    if (a == 1)
        Console.WriteLine("Понедельник.");
    else if (a == 2)
        Console.WriteLine("Вторник.");
    else if (a == 3)
        Console.WriteLine("Среда.");
    else if (a == 4)
        Console.WriteLine("Четверг.");
    else if (a == 5)
        Console.WriteLine("Пятница.");
    else if (a == 6)
        Console.WriteLine("Суббота.");
    else if (a == 7)
        Console.WriteLine("Воскресенье.");
    else
    {
        Console.WriteLine("Неверный ввод.");
    }
}
//task15();



Console.WriteLine("Введите день недели: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 0 && a < 8)

    if (a == 6 || a == 7)
    {
        Console.WriteLine("Выходной.");
    }
    else
    {
        Console.WriteLine("Будни.");
    }
else
{
    Console.WriteLine("Ввод неверный.");
}













// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
void task64()

{
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());

    void Count(int num)
    {
        if (num < 0)
            Console.Write($"{num} Это не натуральное число");
        if (num == 0) return;
        Console.Write($"{num} ");
        Count(num - 1);
    }
    Count(num);
}
//task64();

void task66()
{
    // Задача 66: Задайте значения M и N. Напишите программу, 
    // которая найдёт сумму натуральных элементов в промежутке от M до N.
    // M = 1; N = 15 -> 120
    // M = 4; N = 8. -> 30



    Console.WriteLine("Введите M:");
    int NumberM = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите N:");
    int NumberN = Convert.ToInt32(Console.ReadLine());

    void NumSum(int NumberM, int NumberN, int sum)
    {
        if (NumberM > NumberN)
        {
            Console.WriteLine($"Сумма элементов от М до N = {sum}");
            return;
        }
        sum = sum + (NumberM++);
        NumSum(NumberM, NumberN, sum);
    }

    NumSum(NumberM, NumberN, 0);
}
//task66();

void task68()
{
    //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    // m = 2, n = 3 -> A(m,n) = 9
    // m = 3, n = 2 -> A(m,n) = 29

    int a = InputOfDigits("Введите число a: ");
    int b = InputOfDigits("Введите число b: ");

    int FuncOfAkkerman = AFunc(a, b);

    Console.Write($"Значение функции Аккермана = {FuncOfAkkerman} ");

    int AFunc(int a, int b)
    {
        if (a == 0) return b + 1;
        else if (b == 0) return AFunc(a - 1, 1);
        else return AFunc(a - 1, AFunc(a, b - 1));
    }

    int InputOfDigits(string input)
    {
        Console.Write(input);
        int output = Convert.ToInt32(Console.ReadLine());
        return output;
    }

}
task68();
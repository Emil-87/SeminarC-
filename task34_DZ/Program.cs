void task34_DZ()
{
    //Задача 34. Задайте массив заполненный случайными положительными трехзначными числами
    // Напишите программу, которая покажет количество четных чисел в массиве.
    Console.WriteLine("\t \n ------Task 34 DZ-------");
    int size = 5;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    void FillArray(int[] numbers)
    {
        Random random = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(100, 999);
        }
    }
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] % 2 == 0) count++;
    }
    Console.Write("Количество четных элементов: " + count);
    void PrintArray(int[] numbers)
    {

        Console.WriteLine("Вывод массива: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}
//task34_DZ();

void task36()
{
    // Задача 36. Задайте одномерный массив, заполненный случайными числами.
    // Найдите сумму элементов, стоящих на нечетных позициях?
    Console.WriteLine("\n \t ------ Task 37 DZ ------");
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);

    void FillArray(int[] numbers)
    {
        Random random = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(10, 100);
        }
    }

    int count = 0;
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0) count++;
        if (i % 2 == 1) sum += numbers[i];
    }

    void PrintArray(int[] numbers)
    {
        Console.WriteLine("Вывод массива: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Количество четных элементов: " + count);
    Console.WriteLine("Сумма нечетных элементов массива: " + sum);
}
//task36();

void task38_DZ()
{
    // Задача 38. Задайте массив вещественных чисел. Найдите разницу между 
    // максимальным и минимальным элементов массива.
    Console.WriteLine("\t \n ------Task 38 DZ------");
    int size = 5;
    double[] numbers = new double[size];
    FillArray(numbers);
    PrintArray(numbers);

    void FillArray(double[] numbers)
    {
        Random random = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Math.Round(random.NextDouble() * 20 - 10, 2);
        }
    }

    void PrintArray(double[] numbers)
    {
        Console.WriteLine("Вывод массива: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write(" " + numbers[i]);
        }
    }

}
task38_DZ();
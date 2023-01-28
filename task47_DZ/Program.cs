
void task47_DZ()
{
    // Задача 47. Задайте двумерный массив рахмером МхН,
    // заполненный случайными вещественными числами.

    Random random = new Random();
    int rows = random.Next(2, 6);
    int columns = random.Next(4, 9);

    double[,] numbers = new double[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);

    void FillArray(double[,] numbers)
    {
        Random random = new Random();
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                numbers[i, j] = Math.Round(random.NextDouble() * 10 - 5, 2);
            }
        }
    }

    void PrintArray(double[,] numbers)
    {
        Console.WriteLine();
        Console.WriteLine("Вывод массива: ");
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(numbers[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}


//task47_DZ();

void task50()
{
    // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
    //  и возвращает значение этого элемента или же указание, что такого массива нет.

    Random random = new Random();
    int rows = random.Next(2, 6);
    int columns = random.Next(4, 9);

    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);

    Console.WriteLine("Введите номер строку искомого элемента: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца искомого элемента: ");
    int column = Convert.ToInt32(Console.ReadLine());
    if (row >= 1 && row <= rows && column >= 1 && column <= columns)
    {
        Console.WriteLine($"Искомый элемент [{row}, {column}] = {numbers[row - 1, column - 1]}");
    }
    else
    {
        Console.WriteLine("Искомый элемент не найден");
    }


}
//task50();

void task52()
{
    // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
    // элементов в каждом столбце?

    Random random = new Random();
    int rows = random.Next(2, 6);
    int columns = random.Next(4, 9);

    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);

    Console.WriteLine("Вывод массива по столбцам: ");
    for (int j = 0; j < columns; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += numbers[i, j];
        }
     
        Console.Write(sum/rows + "\t");

    }
    Console.WriteLine();
}
task52();

void FillArray(int[,] numbers)
{

    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = random.Next(0, 10);
        }
    }
}

void PrintArray(int[,] numbers)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива: ");
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(numbers[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
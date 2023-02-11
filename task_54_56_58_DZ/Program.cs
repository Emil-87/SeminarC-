// Задача 54. Задайте двумерный массив. Напишите программу,которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

void task54()
{
    Random random = new Random();
    int rows = random.Next(4, 6);
    int columns = random.Next(4, 6);
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    ArrangeArray(numbers);

    void ArrangeArray(int[,] numbers)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                int border = columns - j - 1;
                for (int k = 0; k < border; k++)
                {
                    if (numbers[i, k] < numbers[i, k + 1])
                    {
                        (numbers[i, k], numbers[i, k + 1]) =
                                     (numbers[i, k + 1], numbers[i, k]);

                    }
                }
            }
        }
    }
    Console.WriteLine();
    PrintArray(numbers);


}
//task54();

void task56()
{
    // Задача 56. Задайте прямоугольный двумерный массив. Напишите программу,которая будет
    // находить строку с наименьшей суммой элементов.

    Random random = new Random();
    int rows = random.Next(4, 6);
    int columns = random.Next(4, 6);
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    SortArray(numbers);

    void SortArray(int[,] numbers)
    {
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);

        int sumMin = SumInRow(numbers, 0);
        int IndexMin = 0;

        for (int i = 1; i < rows; i++)
        {
            int sum = SumInRow(numbers, i);
            if (sum < sumMin)
            {
                sumMin = sum;
                IndexMin = i;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Минимальная сумма равна {sumMin} находится в строке {IndexMin + 1}");

    }
    int SumInRow(int[,] numbers, int i)
    {
        int columns = numbers.GetLength(1);
        int sum = 0;
        for (int j = 0; j < rows; j++)
        {
            sum += numbers[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки равна {sum}");
        return sum;
    }
}

//task56();

void task58()
{
    //     Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
    // произведение двух матриц.
    // Например, даны 2 матрицы:
    // 2 4 | 3 4
    // 3 2 | 3 3
    // Результирующая матрица будет:
    // 18 20
    // 15 18

    int[,] Matrix1 = new int[,]{{7, 0},
                             {6, 8}};
    int[,] Matrix2 = new int[,]{{1, 1},
                             {8, 4}};
    int[,] ResultMatrix = new int[Matrix1.GetLength(0), Matrix1.GetLength(0)];

    for (int i = 0; i < ResultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < ResultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < Matrix1.GetLength(1); k++)
            {
                sum += Matrix1[i, k] * Matrix2[k, j];
            }
            ResultMatrix[i, j] = sum;
        }
    }

    for (int i = 0; i < ResultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < ResultMatrix.GetLength(1); j++)
        {
            Console.Write(ResultMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
// task58();

void task60()
{

    // Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
    //  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
    // Массив размером 2 x 2 x 2
    // 66(0,0,0) 25(0,1,0)
    // 34(1,0,0) 41(1,1,0)
    // 27(0,0,1) 90(0,1,1)
    // 26(1,0,1) 55(1,1,1)

    void NewMatrix(int[,,] array3D)
    {
        int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
        int num = 0;
        for (int i = 0; i < temp.GetLength(0); i++)
        {
            temp[i] = new Random().Next(10, 100);
            num = temp[i];
            if (i >= 1)
            {
                for (int j = 0; j < i; j++)
                {
                    while (temp[i] == temp[j])
                    {
                        temp[i] = new Random().Next(10, 100);
                        j = 0;
                        num = temp[i];
                    }
                    num = temp[i];
                }
            }
        }
        int count = 0;
        for (int x = 0; x < array3D.GetLength(0); x++)
        {
            for (int y = 0; y < array3D.GetLength(1); y++)
            {
                for (int z = 0; z < array3D.GetLength(2); z++)
                {
                    array3D[x, y, z] = temp[count];
                    count++;
                }
            }
        }
    }

    void ShowArray(int[,,] array3D)
    {
        for (int i = 0; i < array3D.GetLength(0); i++)
        {
            for (int j = 0; j < array3D.GetLength(1); j++)
            {
                for (int k = 0; k < array3D.GetLength(2); k++)
                {
                    Console.WriteLine($"{array3D[i, j, k]} ({i},{j},{k})");
                }
            }
        }
    }

    int[,,] Matrix3D = new int[2, 2, 2];
    NewMatrix(Matrix3D);
    ShowArray(Matrix3D);
}
//task60();

void task62()
{
    // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
    // Например, на выходе получается вот такой массив:

    void ShowArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] / 10 <= 0)
                {
                    Console.Write($" {array[i, j]} ");
                }
                else
                {
                    Console.Write($"{array[i, j]} ");
                }
            }
            Console.WriteLine();
        }
    }

    void CreateHelicalArray(int[,] array)
    {
        int temp = 1;
        int i = 0;
        int j = 0;

        while (temp <= array.GetLength(0) * array.GetLength(1))
        {
            array[i, j] = temp;
            temp += 1;

            if (i <= j + 1 && i + j < array.GetLength(1) - 1)
                j += 1;
            else if (i < j && i + j >= array.GetLength(0) - 1)
                i += 1;
            else if (i >= j && i + j > array.GetLength(1) - 1)
                j -= 1;
            else
                i -= 1;
        }
    }

    const int arraySize = 4;
    int[,] squareMatrix = new int[arraySize, arraySize];

    CreateHelicalArray(squareMatrix);
    ShowArray(squareMatrix);
}

task62();

void FillArray(int[,] numbers)
{

    Random random = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {

            numbers[i, j] = random.Next(2, 6);
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

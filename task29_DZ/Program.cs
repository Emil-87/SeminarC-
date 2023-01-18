// Задача 29. Напишите программу, которая задает массив из 8 случайных целых чисел
// и выводит отсортированный по модулю массив.
// -2,1,7,5,19 ->[1,-2,5,7,19]
//  6,1,-33 -> [1,6,33]


int[] arr = { -2, 1, 7, 5, 19 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();

}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }


        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);




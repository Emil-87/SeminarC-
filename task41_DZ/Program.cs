void task41_DZ()
{
    // Задача 41. Пользователь вводит с клавиатуры М чисел.
    // Посчитайте, сколько чисел больше 0 ввел пользователь?
    Console.WriteLine(" Сколько чисел требуется ввести?: ");
    int countOfnumbers = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    for (int i = 1; i <= countOfnumbers; i++)
    {
        Console.WriteLine($"Введите {i} число: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());
        if (inputNumber > 0) count++;
    }
    Console.WriteLine("Положительных чисел введено: " + count);

}
task41_DZ();
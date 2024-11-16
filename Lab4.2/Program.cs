try
{
    Console.Write("Введите количество строк (n): ");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов (m): ");
    int m = int.Parse(Console.ReadLine());

    int[,] array = new int[n, m];
    Console.WriteLine($"Введите элементы массива размером {n}x{m}:");

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write($"Введите элемент [{i},{j}]: ");
            array[i, j] = int.Parse(Console.ReadLine());
        }
    }

    int evenCount = 0;
    int oddCount = 0;

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (array[i, j] % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }
    }

    Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
    Console.WriteLine($"Количество нечетных чисел в массиве: {oddCount}");
}
catch
{
    Console.WriteLine("Введите правильно значение!");
}
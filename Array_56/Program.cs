//Array_56

//Дана двумерный массив n*m заполненный значениями с клавиатуры.
//Упорядочить значения каждой четной строки по возрастанию, а нечетной строки по убыванию.


Console.WriteLine("Введите размер матрицы по горизонтали: ");
string inpCols = Console.ReadLine();
Console.WriteLine("Введите размер матрицы по вертикали: ");
string inpRows = Console.ReadLine();
if (inpCols != "" || inpRows != "")
{
    if (int.TryParse(inpCols, out int colums) && int.TryParse(inpRows, out int rows))
    {
        if (colums > 0 && rows > 0)
        {
            int[,] array = new int[rows, colums];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine($"Введите для {i} сроки {colums} элементов:");
                try
                {
                    int[] row = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    for (int j = 0; j < colums; j++)
                        array[i, j] = row[j];
                }
                catch
                {
                    Console.WriteLine("Ошибка ввода. Не корректная строка!");
                    Console.ReadKey();
                    return;
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1) - 1; j++)
                    for (int k = j + 1; k < array.GetLength(1); k++)
                    {
                        if (i % 2 == 0)
                        {
                            if (array[i, j] > array[i, k])
                            {
                                int temp = array[i, j];
                                array[i, j] = array[i, k];
                                array[i, k] = temp;
                            }
                        }
                        else
                        {
                            if (array[i, j] < array[i, k])
                            {
                                int temp = array[i, j];
                                array[i, j] = array[i, k];
                                array[i, k] = temp;
                            }
                        }
                    }
            Console.WriteLine("Полученный массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        else Console.WriteLine("Длина массива не может быть отрицательной!");
    }
    else Console.WriteLine("Ошибка ввода. Не корректное число!");
}
else Console.WriteLine("Ошибка ввода. Пустая строка.");
Console.ReadKey();
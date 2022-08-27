//Array_49*

//Дан пустой двумерный массив размеров n*n.
//Заполнить массив чередованием значений 0, 1, 2, 3 и 4 в следующем виде:

//0   1   1   1   1   1   0
//4   0   1   1   1   0   2
//4   4   0   1   0   2   2
//4   4   4   0   2   2   2
//4   4   0   3   0   2   2
//4   0   3   3   3   0   2
//0   3   3   3   3   3   0

Console.WriteLine("Введите размер квадратной матрицы: ");
string input = Console.ReadLine();
if (input != "")
{
    if (int.TryParse(input, out int size))
    {
        if (size > 0)
        {
            Console.WriteLine("Полученный массив: ");
            int[,] array = new int[size, size];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i >= 0 && i <= size / 2 - 1) &&
                    (j >= i + 1 && j <= size - (2 + i))) array[i, j] = 1;
                    else if ((i >= size / 2 + 1 && i <= size) &&
                       (j >= size - i && j <= size - (size - i + 1))) array[i, j] = 3;
                    else if ((j >= size / 2 + 1 && j <= size) &&
                       (i >= size - j && i <= size - (size - j + 1))) array[i, j] = 2;
                    else if ((j >= 0 && j <= size / 2 - 1) &&
                       (i >= j + 1 && i <= size - (2 + j))) array[i, j] = 4;
                    else array[i, j] = 0;
                    Console.Write(" " + array[i, j]);
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
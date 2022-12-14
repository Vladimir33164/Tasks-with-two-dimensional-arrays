//Array_48

//Дан пустой двумерный массив размеров n*n.
//Заполнить массив чередованием значений 1, 0 и 2, в следующем виде:

//2   2    2   2   2    2   0
//2   2    2   2   2    0   1
//2   2    2   2   0    1   1
//2   2    2   0   1    1   1  
//2   2    0   1   1    1   1     
//2   0    1   1   1    1   1 
//0   1    1   1   1    1   1

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
                    if (size - i - 1 > j) array[i, j] = 2;
                    else if (size - i - 1 < j) array[i, j] = 1;
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
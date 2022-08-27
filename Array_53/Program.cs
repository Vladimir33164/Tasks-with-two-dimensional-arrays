//Array_53

//Дана двумерный массив n*m заполненный значениями с клавиатуры.
//Найти минимальное и максимальное значения, и вывести их индексы элементов.


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
            int min, max;
            min = max = array[0, 0];
            string idMin = "0, 0", idMax = "0, 0";
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        idMin = i.ToString() + ", " + j.ToString();
                    }
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        idMax = i.ToString() + ", " + j.ToString();
                    }
                }
            Console.WriteLine("Минимальный элемент в массиве = " +
                                 min + ", на позиции - " + idMin);
            Console.WriteLine("Максимальный элемент в массиве = " +
                                 max + ", на позиции - " + idMax);
        }
        else Console.WriteLine("Длина массива не может быть отрицательной!");
    }
    else Console.WriteLine("Ошибка ввода. Не корректное число!");
}
else Console.WriteLine("Ошибка ввода. Пустая строка.");
Console.ReadKey();
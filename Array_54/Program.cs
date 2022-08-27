//Array_54

//Дана двумерный массив n*m заполненный значениями с клавиатуры.
//Вывести в консоль минимальную и максимальную по сумме значений строку.


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
            int min = int.MaxValue, max = int.MinValue;
            int idMin = 0, idMax = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine($"Введите для {i} сроки {colums} элементов:");
                try
                {
                    int[] row = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    int sum = 0;
                    for (int j = 0; j < colums; j++)
                    {
                        array[i, j] = row[j];
                        sum += array[i, j];
                    }
                    if (sum < min)
                    {
                        min = sum; idMin = i;
                    }
                    if (sum > max)
                    {
                        max = sum; idMax = i;
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка ввода. Не корректная строка!");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine("Минимальная сумма элементов в строке = " +
                              min + ", под индексом - " + idMin);
            Console.WriteLine("Максимальная сумма элементов в строке = " +
                              max + ", под индексом - " + idMax);
        }
        else Console.WriteLine("Длина массива не может быть отрицательной!");
    }
    else Console.WriteLine("Ошибка ввода. Не корректное число!");
}
else Console.WriteLine("Ошибка ввода. Пустая строка.");
Console.ReadKey();
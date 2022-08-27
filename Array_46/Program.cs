//Array_46

//Дан пустой двумерный массив размеров n*m.
//Заполнить элементы массива значениями выражения 1…n * 1…m.


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
            Console.WriteLine("Полученный массив: ");
            int[,] array = new int[rows, colums];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = (i + 1) * (j + 1);
                    int maxLen = (colums * rows).ToString().Length + 1;
                    string spase = new string(' ', maxLen - array[i, j].ToString().Length);
                    Console.Write(spase + array[i, j]);
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

//Array_55

//Дана двумерный массив n*m заполненный значениями с клавиатуры.
//Создать и вывести в консоль значения нового массива содержащие 
//минимальное и максимальное значение каждой строки.


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
            int[,] extremums = new int[rows, 2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int min = array[i, 0], max = array[i, 0];
                for (int j = 1; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                        min = array[i, j];
                    if (array[i, j] > max)
                        max = array[i, j];
                }
                Console.WriteLine($"Строка №{i}: мin = {min};\tmax = {max}");
                extremums[i, 0] = min;
                extremums[i, 1] = max;
            }
        }
        else Console.WriteLine("Длина массива не может быть отрицательной!");
    }
    else Console.WriteLine("Ошибка ввода. Не корректное число!");
}
else Console.WriteLine("Ошибка ввода. Пустая строка.");
Console.ReadKey();
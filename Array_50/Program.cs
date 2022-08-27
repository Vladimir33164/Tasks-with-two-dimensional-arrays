//Array_50

//Даны два целых числа n и m. Создайте двумерный массив [n, m] и заполните его по следующим правилам:

//числа, стоящие в строке 0 или в столбце 0 равны 1;
//для всех остальных элементов массива — элемент равен сумме двух элементов,
//стоящих слева и сверху от него.
/*
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
                for (int j = 0; j < array.GetLength(1); j++)
                    if (i == 0 || j == 0) array[i, j] = 1;
                    else array[i, j] = array[i - 1, j] + array[i, j - 1];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int maxLen = (array[rows - 1, colums - 1]).ToString().Length + 1;
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
*/
//Или сократим, где можно воспользоваться в выводе элемента массива табуляцией:

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
                    array[i, j] = (i == 0 || j == 0) ? 1 : array[i - 1, j] + array[i, j - 1];
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        } else Console.WriteLine("Длина массива не может быть отрицательной!");
    } else Console.WriteLine("Ошибка ввода. Не корректное число!");
} else Console.WriteLine("Ошибка ввода. Пустая строка.");
    
Console.ReadKey();
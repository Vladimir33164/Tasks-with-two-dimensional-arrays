//Array_52

//Дан пустой двумерный массив размеров n*m. Заполнить массив уникальными значениями от 1 до n*m.


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
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = (i * colums) + j;
            Random rnd = new Random();
            for (int i = 0; i < rows * colums; i++)
            {
                int idFstA = rnd.Next(0, rows), idFstB = rnd.Next(0, colums);
                int idSndA = rnd.Next(0, rows), idSndB = rnd.Next(0, colums);
                int temp = array[idFstA, idFstB];
                array[idFstA, idFstB] = array[idSndA, idSndB];
                array[idSndA, idSndB] = temp;
            }
            Console.WriteLine("Полученный массив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i, j] + "\t");
                Console.WriteLine();
            }
        }
        else Console.WriteLine("Длина массива не может быть отрицательной!");
    }
    else Console.WriteLine("Ошибка ввода. Не корректное число!");
}
else Console.WriteLine("Ошибка ввода. Пустая строка.");
Console.ReadKey();
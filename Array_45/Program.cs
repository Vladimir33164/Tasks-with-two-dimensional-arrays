//Array_45
//Дан пустой двумерный массив размеров n*n.
//Заполнить массив значениями от нуля до n*n.

//0   1   2   3   4
//5   6   7   8   9
//10  11  12  13  14
//15  16  17  18  19
//20  21  22  23  24

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
                    array[i, j] = i * size + j;
                    int maxLen = (size * size).ToString().Length + 1;
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

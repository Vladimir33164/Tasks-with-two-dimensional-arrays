//Array_51

//Дан с клавиатуры квадратная матрица целых значений.
//Необходимо определить, симметрична ли матрица относительно главной диагонали.
//Главная диагональ — это диагональ,
//которая идёт из левого верхнего угла матрицы в правый нижний.


Console.WriteLine("Введите размер квадратной матрицы: ");
string input = Console.ReadLine();
if (input != "")
{
    if (int.TryParse(input, out int size))
    {
        if (size > 0)
        {
            int[,] array = new int[size, size];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine($"Введите для {i} сроки {size} элементов:");
                try
                {
                    int[] row = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    for (int j = 0; j < size; j++)
                        array[i, j] = row[j];
                }
                catch
                {
                    Console.WriteLine("Ошибка ввода. Не корректная строка!");
                    Console.ReadKey();
                    return;
                }
            }
            for (int i = 0; i < array.GetLength(0) - 1; i++)
                for (int j = 0; j < array.GetLength(1) - i; j++)
                    if (array[i + j, i] != array[i, i + j])
                    {
                        Console.WriteLine("Матрица несимметрична!");
                        Console.ReadKey();
                        return;
                    }
            Console.WriteLine("Матрица симметрична!");
        }
        else Console.WriteLine("Длина массива не может быть отрицательной!");
    }
    else Console.WriteLine("Ошибка ввода. Не корректное число!");
}
else Console.WriteLine("Ошибка ввода. Пустая строка.");
Console.ReadKey();
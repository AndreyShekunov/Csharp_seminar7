// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int ReadNumber(string message) // метод ввода числа
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

// метод создания двумерного массив (матрицы)
int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10) // - 10 и 10 значения по умолчанию
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

// метод поиска элемента массива по его индексам
void FindElementMatrixByIndex(int[,] matrix, int indexI, int indexJ)
{
    if (indexI < 0 || indexJ < 0)
    {
        Console.WriteLine("Оба индекса должны быть >= 0");
    }
    else
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == indexI && j == indexJ)
                {
                    Console.WriteLine($"Елемент массива с индексами [{indexI},{indexJ}] = {matrix[i, j]}");
                }
            }
        }
    }
}

// метод печати двумерного массива (матрицы) на экран
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,5:f}", $"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
int i = ReadNumber("Введите индекс строки");
int j = ReadNumber("Введите индекс столбца");

if (i > m - 1 || j > n - 1)
{
    Console.WriteLine($"Елемент в массиве с индексами [{i},{j}] отсутствует");
}
else
{
    FindElementMatrixByIndex(matr, i, j);
}
    
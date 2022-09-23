// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// Например:
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadNumber(string message) // метод ввода числа
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

// метод создания двумерного массив типа double
double[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
{
    double[,] matrix = new double[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.NextDouble()*(rightRange - leftRange) + leftRange;
        }
    }
    return matrix;
}

// метод печати двумерного массива типа double на экран
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,5:f1}", matrix[i, j]));
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
double[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
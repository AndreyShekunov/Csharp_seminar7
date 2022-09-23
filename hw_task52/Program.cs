// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadNumber(string message) // метод ввода числа
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

// метод создания двумерного массив (матрицы)
int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 1, int rightRange = 10) // - 10 и 10 значения по умолчанию
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

// метод поиска среднего арифметического элементов в каждом столбце
void MeanOfElementsInColumns(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double average = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            average = average + matrix[j,i];
        }
        Console.Write(String.Format("{0,4:f}", $"{Math.Round(average/matrix.GetLength(0), 2)}; "));
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
MeanOfElementsInColumns(matr);
// Задача 51: Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольный

int ReadNumber(string message) // метод ввода числа
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

// метод создания двумерного массив (матрицы)
int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
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

// метод суммирования элементов главной диаганали двумерного массива
int SumElementMatrix(int[,] matrix)
{
    int sumElements = 0;
    int min;
    if(matrix.GetLength(0) >= matrix.GetLength(1)) // определяем что больше строк чем столбцов или они равны
    {
        min = matrix.GetLength(1); // если условие выше верно то min ровно количеству столбцов
    }
    else
    {
        min = matrix.GetLength(0); // иначе min равно количеству строк
    }
    for (int i = 0; i < min; i++)
    {
        sumElements = sumElements + matrix[i, i]; // у главной деоганали индексы равны
    }
    return sumElements;
}

// метод печати двумерного массива (матрицы) на экран
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
int sum = SumElementMatrix(matr);
Console.WriteLine($"Сумма чисел главной диоганали матрицы = {sum}");

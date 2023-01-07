/*
Транспонирование - 4

(Время: 1 сек. Память: 16 Мб Сложность: 15%)
Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее относительно горизонтали.

Входные данные
Первая строка входного файла INPUT.TXT содержит два натуральных числа N и M – количество строк и столбцов матрицы. 
В каждой из последующих N строк записаны M целых чисел – элементы матрицы. 
Все числа во входных данных не превышают 100 по абсолютной величине.

Выходные данные
В выходной файл OUTPUT.TXT выведите матрицу, полученную транспонированием исходной матрицы относительно горизонтали.
*/


void FillMatirx(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
            Console.Write($"{matrix[i, j]} \t");

        }
        Console.WriteLine();
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine();
}
void transp(int[,] new_matrix, int[,] matrix)
{
    for (int i = 0; i < new_matrix.GetLength(0); i++)
    {
        for (int j = 0; j < new_matrix.GetLength(1); j++)
        {
            new_matrix[i, j] = matrix[matrix.GetLength(0) - 1 - i, j];
            Console.Write($"{new_matrix[i, j]} \t");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
int[,] new_matrix = new int[size[0], size[1]];
FillMatirx(matrix);
transp(new_matrix, matrix);
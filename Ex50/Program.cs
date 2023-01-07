/*
Задача 50. 

Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1 7 -> такой позиции в массиве нет
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
}
void FindElement(int[] Elem, int[] size, int[,] matrix)
{
    if (((Elem[0] < 1) || Elem[0] > matrix.GetLength(0)) || ((Elem[1] < 1) || Elem[1] > matrix.GetLength(1)))
    {
        Console.WriteLine("Такой позиции в тексте нет.");
        return;
    }
    Console.Write($"{matrix[Elem[0] - 1, Elem[1] - 1]}");
}

//void Release(double[,] matrix)
Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.Write("Введите положение элемента: ");
int[] Elem = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
FillMatirx(matrix);
FindElement(Elem, size, matrix);



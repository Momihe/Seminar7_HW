/*
Миша и негатив
(Время: 1 сек. Память: 16 Мб Сложность: 17%)
Миша уже научился хорошо фотографировать и недавно увлекся программированием. Первая программа, 
которую он написал, позволяет формировать негатив бинарного черно-белого изображения.

Бинарное черно-белое изображение – это прямоугольник, состоящий из пикселей, каждый из которых может 
быть либо черным, либо белым. Негатив такого изображения получается путем замены каждого черного пикселя на белый, 
а каждого белого пикселя – на черный.

Миша, как начинающий программист, написал свою программу с ошибкой, поэтому 
в результате ее исполнения мог получаться некорректный негатив. Для того чтобы 
оценить уровень несоответствия получаемого негатива исходному изображению, Миша 
начал тестировать свою программу.

В качестве входных данных он использовал исходные изображения. Сформированные программой 
негативы он начал тщательно анализировать, каждый раз определяя число 
пикселей негатива, которые получены с ошибкой.

Требуется написать программу, которая в качестве входных данных использует исходное 
бинарное черно-белое изображение и полученный Мишиной программой негатив, и на основе 
этого определяет количество пикселей, в которых допущена ошибка.

Входные данные
Первая строка входного файла INPUT.TXT содержит целые числа n и m (1 ≤ n, m ≤ 100) – высоту и ширину 
исходного изображения (в пикселях). Последующие n строк содержат описание исходного изображения. 
Каждая строка состоит из m символов «B» и «W». Символ «B» соответствует черному 
пикселю, а символ «W» – белому. Далее следует пустая строка, а после нее – описание выведенного 
Мишиной программой изображения в том же формате, что и исходное изображение.

Выходные данные
В выходной файл OUTPUT.TXT необходимо вывести число пикселей негатива, 
которые неправильно сформированы Мишиной программой.
*/


void PrintMatirx(string[,] matrix)
{
    Console.WriteLine("Случайно сгенерированная матрица.");
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int x = new Random().Next(0, 2);
            if (x == 0) matrix[i, j] = "B";
            else matrix[i, j] = "W";

            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();

    }
    Console.WriteLine();

}
void PrintNegativ(string[,] matrix, string[,] neg)
{
    Console.WriteLine("Матрица - негатив.");
    Console.WriteLine();
    for (int i = 0; i < neg.GetLength(0); i++)
    {
        int x = new Random().Next(0, neg.GetLength(1) - 1);
        for (int j = 0; j < neg.GetLength(1); j++)
        {
            if (matrix[i, j] == "W") neg[i, j] = "B";
            else neg[i, j] = "W";
            Console.Write($"{neg[i, j]}  ");

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void ErrorGenerator(string[,] neg, string[,] erroneg)
{
    Console.WriteLine("Матрица - негатив с ошибками. По одной ошибке на строку.");
    Console.WriteLine();
    for (int i = 0; i < neg.GetLength(0); i++)
    {
        int x = new Random().Next(0, neg.GetLength(1) - 1);
        for (int j = 0; j < neg.GetLength(1); j++)
        {
            erroneg[i, j] = neg[i, j];
            if ((j == x) && (erroneg[i, j] == "W")) erroneg[i, j] = "B";
            else if ((j == x) && (erroneg[i, j] == "B")) erroneg[i, j] = "W";
            Console.Write($"{erroneg[i, j]}  ");
        }
        Console.WriteLine();
    }
}
void ErrorCount(string[,] erroneg, string[,] neg)
{
    int errorcount = 0;
    for (int i = 0; i < neg.GetLength(0); i++)
    {
        for (int j = 0; j < neg.GetLength(1); j++)
        {
            if (erroneg[i, j] != neg[i, j]) errorcount++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Количество ошибок: {errorcount}");
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
string[,] matrix = new string[size[0], size[1]];
string[,] neg = new string[size[0], size[1]];
string[,] erroneg = new string[size[0], size[1]];
Console.WriteLine();
PrintMatirx(matrix);
PrintNegativ(matrix, neg);
ErrorGenerator(neg, erroneg);
ErrorCount(erroneg, neg);
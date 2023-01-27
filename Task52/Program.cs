// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[m, n];

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i,j] = new Random().Next(1,100);
            }
        }
}

void ArrayAverage()
{
    for (var i=0; i<n; i++)
    {
        var result = 0;

        for(var j = 0; j<m; j++)
        {
            result+=matrix[j,i];
        }
        Console.WriteLine(result/m);
    }
}


FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
ArrayAverage();
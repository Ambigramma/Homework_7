// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите ряд: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите столбец: ");
int column = int.Parse(Console.ReadLine());


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
    if (row < matr.GetLength(0) && column < matr.GetLength(1)) 
    {
        Console.WriteLine("число в указанном ряде и столбце:"+matr[row, column]);
    }
    else Console.WriteLine($"{row}{column} -> такого числа в массиве нет");
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i,j] = new Random().Next(-100,100);
            }
        }
}    


FillArray(matrix);
Console.WriteLine();

PrintArray(matrix);
Console.WriteLine();

//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
Console.WriteLine("Введите размерность матриц : ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] arrayA = new int[size, size];
int[,] arrayB = new int[size, size];
FillRandom(arrayA);
FillRandom(arrayB);
int[,] arrayC = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            arrayC[i, j] = arrayC[i, j] + (arrayA[i, k] * arrayB[k, j]);
        }
    }
}
Console.WriteLine("Матрица - А");
Print(arrayA);
Console.WriteLine();
Console.WriteLine("Матрица - В");
Print(arrayB);
Console.WriteLine();
Console.WriteLine("Произведение матриц А*В");
Print(arrayC);

void FillRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
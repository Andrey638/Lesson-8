// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента
Console.WriteLine("Введите размер массива m - n - c");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int[,,] array3D = Create3Darray(m, n, c);

Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < c; k++)
        {
            Console.WriteLine($"[{i},{j},{k}] - {array3D[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] Create3Darray(int m, int n, int c)
{
    int countNums = 99;
    int[,,] array = new int[m, n, c];
    int[] values = new int[countNums];
    int num = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}
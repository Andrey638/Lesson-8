//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Введите размер массива m - n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
Random random = new Random();
int minsum = Int32.MaxValue;
int index = 0;
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = random.Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
for (int i = 0; i < m; i++)
{
    int sum = 0;
    for (int j = 0; j < n; j++)
    {
        sum = sum + array[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        index++;
    }
}
Console.WriteLine("строка с наименьшей суммой елементов : " + (index) + ", сумма равна: " + (minsum));

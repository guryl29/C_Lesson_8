/* Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку
с наименьшей суммой элементов. */

Console.WriteLine("Введите количество строк ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов ");
int m = int.Parse(Console.ReadLine());


int[,] GetArray(int n, int m, int minValue, int maxValue)
{
    int[,] result = new int[n, m];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
          result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;  
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
        
    }
}

int sumStr(int [,] array)
{
    int sumStr =0;
    int count=0;
    
    for (int i = 0; i < array.GetLength(0); i++)
        
        { int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i,j]; 
                                         
            }
            count++;
            sumStr=sum;
            Console.WriteLine($"сумма {count} строки равно {sumStr}");  
        }
     
    return sumStr;
} 
Console.WriteLine();
int[,] myArray = GetArray(n, m, 0, 10);
PrintArray(myArray);
Console.WriteLine();
sumStr(myArray);
rowSum(myArray);

void rowSum(int[,] arr)
{
    int sum;
    int temp = int.MaxValue;
    int index = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i, j];
        }
        if (sum <= temp)
        {
            temp = sum;
            index = i + 1;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Строка {index} с наименьшей суммой = {temp}");
}

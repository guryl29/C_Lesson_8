/* Задайте двумерный массив.
Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива. */


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

int[,] myArray = GetArray(n, m, 0, 10);
PrintArray(myArray);
Console.WriteLine();

for( int i = 0; i < myArray.GetLength(0); i++)
    {
        for( int j = 0; j < myArray.GetLength(1); j++)
        {
            for( int k = 0; k < myArray.GetLength(1)-1; k++)
            {
                if(myArray[i,j]>myArray[i,k])
                {
                int temp = myArray[i,j];
                myArray[i,j] = myArray[i,k];
                myArray[i,k] = temp;
                }
            }
        }
    }
PrintArray(myArray);
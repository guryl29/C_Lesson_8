/* Сформируйте трёхмерный массив из 
неповторяющихся двузначных чисел.
Напишите программу, которая будет
построчно выводить массив, 
добавляя индексы каждого элемента. */


void FillArray(int[,,] array)
{
    int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    temp[0] = new Random().Next(10, 100);
    int num = temp[0];
    for (int i = 1; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        for (int j = 0; j < i; j++)
        {
            while (temp[i] == temp[j])
            {
                temp[i] = new Random().Next(10, 100);
                num = temp[i];
                j = 0;
            }
            num = temp[i];
        }
    }

    int count = 0;
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] arr = new int[2, 2, 2];
FillArray(arr);
PrintArray(arr);
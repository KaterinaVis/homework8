// Задача 60. Сформируйте трёхмерный массив из случайных неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Например:
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

Console.WriteLine("Введите размер массива X:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива Y:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива Z:");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,,] matrix = new int [x,y,z];

FillRndArray(matrix);
PrintArray (matrix);

-------------------------

void PrintArray (int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
        
    }
}
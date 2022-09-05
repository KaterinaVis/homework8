// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите число строк массива m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива n:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix = new int [m,n];
FillRndArray(matrix);
PrintArray (matrix);

int minsum = 0;
int sum = SumArray(matrix, 0);

for (int i = 1; i < matrix.GetLength(0); i++)
{
  int temp = SumArray(matrix, i);
  if (sum > temp)
  {
    sum = temp;
    minsum = i;
  }
}

Console.WriteLine($"№ строки с наименьшей суммой элементов: {minsum+1}");


int SumArray(int[,] matr, int i)
{
  int sum = matr[i,0];
  for (int j = 1; j < matr.GetLength(1);j++)
  {
    sum += matr[i,j];
  }
  return sum;
}

void PrintArray (int[,] matr) // печать
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
void FillRndArray(int[,] matr) // заполнение рандомом
{
for (int i = 0; i < matr.GetLength(0); i++)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
Random rand = new Random();
matr[i, j] = rand.Next(1, 10);
}
}
}


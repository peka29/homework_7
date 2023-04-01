// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}
void ReleaseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            if (array[0] > matrix.GetLength(0) || array[1] > matrix.GetLength(1))
                Console.WriteLine("такого элемента нет");
        
            else
                Console.WriteLine(matrix[i, j]= matrix[array[0],array[1]]);
                // i = array[0];
                // j = array[1];      
            
        }
    }
}
Console.Clear();
Console.Write("введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.Write("введите позицию элемента по вертикали и горизонтали: ");
ReleaseMatrix(matrix);

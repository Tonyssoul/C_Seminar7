// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1   7 -> такого числа в массиве нет

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }

}

void findElement(int[,] matrix, int row, int col)
{
    if (row > matrix.GetLength(0) || col > matrix.GetLength(1))
    {
        System.Console.WriteLine("Такого элемента не существует");
    }
    else
    {
        System.Console.WriteLine(matrix[row, col]);
    }
}

Random rand = new Random();
int rows = rand.Next(1, 6);
int cols = rand.Next(1, 6);
int row = ReadInt("Введите номер строки елемента ");
int col = ReadInt("Введите номер столбца елемента ");
System.Console.WriteLine();

var myMatrix = GenerateMatrix(rows, cols);
PrintMatrix(myMatrix);

System.Console.WriteLine();
findElement(myMatrix, row, col);
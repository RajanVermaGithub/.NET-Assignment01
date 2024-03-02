﻿using System;

class Program
{
    static void Main()
    {

        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };


        Console.WriteLine("Original Matrix:");
        DisplayMatrix(matrix);


        Console.WriteLine("\nTranspose Matrix:");
        DisplayMatrix(TransposeMatrix(matrix));
    }


    static int[,] TransposeMatrix(int[,] mat)
    {
        int rows = mat.GetLength(0);
        int cols = mat.GetLength(1);
        int[,] transpose = new int[cols, rows];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                transpose[j, i] = mat[i, j];

        return transpose;
    }


    static void DisplayMatrix(int[,] mat)
    {
        int rows = mat.GetLength(0);
        int cols = mat.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(mat[i, j] + "\t");
            }
            Console.WriteLine();
            Console.ReadKey();  
        }
        Console.WriteLine("Created by Rajan Verma");
        Console.WriteLine("MCA-2 A, Roll no.:69");
        Console.ReadKey();
    }  
}
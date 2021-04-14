using System;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] sudoku = new int[,]
            {
               {1, 3, 2, 5, 7, 9, 4, 6, 8 },
               {4, 9, 8, 2, 6, 1, 3, 7, 5},
               {7, 5, 6, 3, 8, 4, 2, 1, 9 },
               {6, 4, 3, 1, 5, 8, 7, 9, 2},
               {5, 2, 1, 7, 9, 3, 8, 4, 6 },
               {9, 8,7, 4, 2, 6, 5, 3, 1 },
               {2, 1, 4, 9, 3, 5, 6, 8, 7 },
               {3, 6, 5, 8, 1, 7, 9, 2, 4 },
               {8, 7, 9, 6, 4, 2, 1, 5, 3 },               
            };

            bool numerosrepetidos = false;
            for (int i = 0; i < sudoku.Length;i++)
            {
                int a = sudoku[i,i];
                int c = i + 1;
                for (int ii = c; ii < sudoku.Length; ii++)
                {
                    int b = sudoku[i,i];
                    if (a == b)
                    {
                        numerosrepetidos = true;
                        Console.WriteLine("NÃO!");
                        if (numerosrepetidos == false)
                        {
                         
                            System.Console.WriteLine("SIM!");
                        }
                    }
                }
            }
       }
    }
}

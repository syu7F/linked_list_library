using System;
using System.Collections.Generic;

namespace MyChessProject;

class MyChess
{
    static void Main()
    {
        int n = 8;

        Console.WriteLine("Գլխավոր անկյունագիծ:");
        PrintMainDiagonal(n);
 

        Console.WriteLine("Երկրորդական անկյունագիծ:");
        PrintSecondDiagonal(n);


        // Նավակի քայլի ստուգում
        Console.WriteLine(PrintCanRookMove(2, 3, 5, 3));


        // Ձիու մեկ քայլի ստուգում
        Console.WriteLine(PrintCanKnightMove(2, 3, 4, 4));


        // Ձիու նվազագույն քայլերը
        int steps = GetKnightMinSteps(1, 1, 8, 8);
        Console.WriteLine(steps);

        // Փղի քայլի ստուգում
        Console.WriteLine(DiagonalBishop(0, 7, 4, 3, 2, 5));

        Console.ReadKey();
    }

    static void PrintMainDiagonal(int matrixSize)
    {
        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = 0; j < matrixSize; j++)
            {
                Console.Write(i == j ? "# " : "* ");
            }
            Console.WriteLine();
        }
    }

    static void PrintSecondDiagonal(int matrixSize)
    {
        for (int x0 = 0; x0 < matrixSize; x0++)
        {
            for (int y0 = 0; y0 < matrixSize; y0++)
            {
                Console.Write(x0 + y0 == matrixSize - 1 ? "# " : "* ");
            }
            Console.WriteLine();
        }
    }

    static bool PrintCanRookMove(int x0, int y0, int x1, int y1)
    {
        if (x0 == x1 && y0 == y1)
            return false;

        return x0 == x1 || y0 == y1;
    }

    static bool PrintCanKnightMove(int x0, int y0, int x1, int y1)
    {
        int dx = Math.Abs(x0 - x1);
        int dy = Math.Abs(y0 - y1);

        return (dx == 2 && dy == 1) || (dx == 1 && dy == 2);
    }

    static int GetKnightMinSteps(int x0, int y0, int x1, int y1)
    {
        int[] dx = { 2, 2, -2, -2, 1, 1, -1, -1 };
        int[] dy = { 1, -1, 1, -1, 2, -2, 2, -2 };

        Queue<(int x, int y, int dist)> queue = new Queue<(int, int, int)>();
        queue.Enqueue((x0, y0, 0));

        bool[,] visited = new bool[9, 9];
        visited[x0, y0] = true;

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            if (current.x == x1 && current.y == y1)
                return current.dist;

            for (int i = 0; i < 8; i++)
            {
                int nextX = current.x + dx[i];
                int nextY = current.y + dy[i];

                if (nextX >= 1 && nextX <= 8 &&
                    nextY >= 1 && nextY <= 8 &&
                    !visited[nextX, nextY])
                {
                    visited[nextX, nextY] = true;
                    queue.Enqueue((nextX, nextY, current.dist + 1));
                }
            }
        }

        return -1;
    }

    static bool DiagonalBishop(int x0, int y0, int x1, int y1, int obstacleX, int obstacleY)
    {
        if (Math.Abs(x0 - x1) == Math.Abs(y0 - y1))
        {
            if (Math.Abs(obstacleX - x1) == Math.Abs(obstacleY - y1))
            {
                if (obstacleX > Math.Min(x1, x0) &&
                    obstacleX < Math.Max(x1, x0))
                {
                    if (obstacleY > Math.Min(y1, y0) &&
                        obstacleY < Math.Max(y1, y0))
                        return false;
                    else
                        return true;
                }
                else
                    return true;
            }
            else
                return true;
        }

        return false;
    }
}
using UnityEngine;

public class GameOfLifeLogic
{
    public static void UpdateCells(Cell[,] cells)
    {
        int rows = cells.GetLength(0);
        int cols = cells.GetLength(1);

        bool[,] newStates = new bool[rows, cols];

        // the rules of Conway's Game of Life
        for (int x = 0; x < rows; x++)
        {
            for (int y = 0; y < cols; y++)
            {
                int liveNeighbors = CountLiveNeighbors(cells, x, y);

                if (cells[x, y].isAlive)
                {
                    newStates[x, y] = liveNeighbors == 2 || liveNeighbors == 3;
                }
                else
                {
                    newStates[x, y] = liveNeighbors == 3;
                }
            }
        }

        for (int x = 0; x < rows; x++)
        {
            for (int y = 0; y < cols; y++)
            {
                cells[x, y].isAlive = newStates[x, y];
                cells[x, y].UpdateCellVisuals(); // Update visuals based on the new state
            }
        }
    }

    private static int CountLiveNeighbors(Cell[,] cells, int x, int y)
    {
        int liveNeighbors = 0;
        int rows = cells.GetLength(0);
        int cols = cells.GetLength(1);

        // Check all eight neighbors
        for (int i = -1; i <= 1; i++)
        {
            for (int j = -1; j <= 1; j++)
            {
                int neighborX = x + i;
                int neighborY = y + j;

                // Skiping the center cell (current cell)
                if (i == 0 && j == 0)
                    continue;

                // Checking if the neighbor is within the bounds of the grid
                if (neighborX >= 0 && neighborX < rows && neighborY >= 0 && neighborY < cols)
                {
                    // Incrementing liveNeighbors if the neighbor is alive
                    if (cells[neighborX, neighborY].isAlive)
                    {
                        liveNeighbors++;
                    }
                }
            }
        }

        return liveNeighbors;
    }
}

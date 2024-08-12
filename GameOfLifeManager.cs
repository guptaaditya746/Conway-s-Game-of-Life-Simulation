using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class GameOfLifeManager : MonoBehaviour
{
    public int gridSizeX = 40;
    public int gridSizeY = 40;
    public float cellSize = 1.0f;
    private Cell[,] cells;
    private int generation = 0;
    public float updateInterval = 0.5f; // Time between updates in seconds
    private float lastUpdateTime = 0f;
     public GenerationDisplay generationDisplay;

    void Start()
    {
        CreateGrid();
        //  InitializePattern1();  // Please update this part to apply different patterns, currently pattern3 is set.
        InitializePattern2();
        // InitializePattern3();

    }

    void Update()
    {
        
        if (Time.time - lastUpdateTime > updateInterval)
        {
            UpdateGame();
            lastUpdateTime = Time.time;
        }
    }

    void CreateGrid()
    {
        cells = new Cell[gridSizeX, gridSizeY];

        for (int x = 0; x < gridSizeX; x++)
        {
            for (int y = 0; y < gridSizeY; y++)
            {
                GameObject cellObject = new GameObject("Cell_" + x + "_" + y);
                float xPos = (x * cellSize) - ((gridSizeX - 1) * cellSize * 0.5f);
                float yPos = (y * cellSize) - ((gridSizeY - 1) * cellSize * 0.5f);
                cellObject.transform.position = new Vector3(xPos, yPos, 0);

                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.parent = cellObject.transform;
                cube.transform.localPosition = Vector3.zero;
                cube.transform.localScale = new Vector3(cellSize, cellSize, cellSize);

                Cell cellScript = cellObject.AddComponent<Cell>();
                cellScript.Initialize(x, y);
                cells[x, y] = cellScript;
            }
        }
    }

    void InitializePattern1()
    {
        int centerX = gridSizeX / 2;
        int centerY = gridSizeY / 2;

        SetCellAlive(centerX - 1, centerY - 1);
        SetCellAlive(centerX, centerY - 1);
        SetCellAlive(centerX - 1, centerY);
        SetCellAlive(centerX, centerY);
    }
     void InitializePattern2()
    {
         int centerX = gridSizeX / 2;
        int centerY = gridSizeY / 2;

       
        SetCellAlive(centerX, centerY);
        SetCellAlive(centerX, centerY + 2);
        SetCellAlive(centerX + 1, centerY + 3);
        SetCellAlive(centerX + 2, centerY + 3);
        SetCellAlive(centerX + 3, centerY + 3);
        SetCellAlive(centerX + 4, centerY + 3);
        SetCellAlive(centerX + 4, centerY + 2);
        SetCellAlive(centerX + 4, centerY + 1);
        SetCellAlive(centerX + 3, centerY );

    }

    void InitializePattern3()
    {
         int centerX = gridSizeX / 2;
        int centerY = gridSizeY / 2;

        SetCellAlive(centerX - 1, centerY - 1);
        SetCellAlive(centerX, centerY - 1);
        SetCellAlive(centerX - 1, centerY);
        SetCellAlive(centerX, centerY);
        SetCellAlive(centerX, centerY + 4);
        SetCellAlive(centerX + 1, centerY + 4);
        SetCellAlive(centerX + 2, centerY + 4);
        SetCellAlive(centerX , centerY + 5);
        SetCellAlive(centerX + 1 , centerY + 6);
    }

    void SetCellAlive(int x, int y)
    {
        if (x >= 0 && x < gridSizeX && y >= 0 && y < gridSizeY)
        {
            cells[x, y].isAlive = true;
            cells[x, y].UpdateCellVisuals();
        }
    }

    void UpdateGame()
    {
        GameOfLifeLogic.UpdateCells(cells);
        generation++;
        generationDisplay.UpdateGeneration(generation); // Update the UI Text using GenerationDisplay
        Debug.Log("Generation: " + generation);
    }
}

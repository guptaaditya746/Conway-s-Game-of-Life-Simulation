# Conway's Game of Life Simulation

## Discussion

## Nassi-Shneiderman Diagrams

### Individual Automat Behavior
<p align="center">
  <img src="https://github.com/guptaaditya746/Conway-s-Game-of-Life-Simulation/blob/main/img/Graph%20to%20represent%20the%20behavior%20of%20a%20single%20automat%20via%20Nassi-Shneiderman.png" alt="Single automata" width="800">
</p>

This diagram outlines the algorithm for determining the next state of a cell based on the Game of Life rules. It checks the current state and the number of live neighbors to decide whether the cell will be alive or dead in the next generation.

### Overall Field Calculation
<p align="center">
  <img src="https://github.com/guptaaditya746/Conway-s-Game-of-Life-Simulation/blob/main/img/Nassi-Shneiderman%20diagram%20for%20the%20calculation%20of%20the%20whole%20field-1.png" alt="Nassi-Shneiderman diagram showing the logic for updating the entire grid of cells" width="800">
</p>

The overall field calculation diagram demonstrates how the simulation iterates through each cell in the grid, applying the rules to determine the next state of the entire population. It utilizes the individual automat behavior logic to update the state of each cell.

### Visualization
<p align="center">
  <img src="https://github.com/guptaaditya746/Conway-s-Game-of-Life-Simulation/blob/main/img/Nassi-Shneiderman%20diagram%20for%20the%20visualization%20of%20the%20field.png" alt="Visualizatin" width="800">
</p>

This diagram depicts the process of visualizing the cell states in the Unity game engine. It involves updating the color and appearance of each cell's representation based on its current state (alive or dead).

## Class Diagrams

<p align="center">
  <img src="https://github.com/guptaaditya746/Conway-s-Game-of-Life-Simulation/blob/main/img/Class%20diagrams%20for%20the%20implemented%20classes.png" alt="Class diagram" width="800">
</p>


The class diagram illustrates the main components of the simulation and their interactions. It includes the `Cell` class for managing individual cell states, the `GameOfLifeManager` class for handling the game logic and simulation loop, and the `GenerationDisplay` class for updating the UI with the current generation count.

## Simulation Results

### Pattern 1
<p align="center">
  <img src="https://github.com/guptaaditya746/Conway-s-Game-of-Life-Simulation/blob/main/img/pattern1_50.png" alt="patttern1_result" width="800">
</p>


The simulation results for Pattern 1 show how the initial configuration evolves over multiple generations, demonstrating the emergent behavior of the cellular automata.

### Pattern 2
<p align="center">
  <img src="https://github.com/guptaaditya746/Conway-s-Game-of-Life-Simulation/blob/main/img/pattern2_50.png" alt="pattern2_50" width="800">
</p>


The simulation results for Pattern 2 illustrate a different initial pattern and its evolution, highlighting the diversity of outcomes that can arise from varying starting conditions.

### Pattern 3
<p align="center">
  <img src="https://github.com/guptaaditya746/Conway-s-Game-of-Life-Simulation/blob/main/img/pattern3_50.png" alt="pattern3_50" width="800">
</p>


The simulation results for Pattern 3 provide insights into the complex and often unpredictable nature of the Game of Life, as the population undergoes changes and reaches different stable or oscillating states over time.


## Overview
This project is a simulation of Conway's Game of Life developed using Unity. It demonstrates the principles of cellular automata and visualizes the evolution of cell states based on defined rules. Users can observe how different initial patterns evolve over multiple generations.

## Features
- **Dynamic Simulation**: Visualizes the behavior of cellular automata over time.
- **User Interface**: Displays the current generation count using a `GenerationDisplay` class.
- **Multiple Patterns**: Allows for different initial patterns to be set for simulation.
- **Interactive Visualization**: Utilizes Unity's rendering capabilities for clear visual representation.

## Technologies Used
- **Unity**: Game engine used for development.
- **C#**: Programming language used for scripting.
- **Object-Oriented Programming**: Employed to structure the code effectively.

## How to Run the Simulation

1. Clone this repository to your local machine:
   ```bash
   git clone https://github.com/yourusername/GameOfLife.git
   ```
2. Open the project in Unity.
3. Press the **Play** button to start the simulation.
4. Use the **Space** key to update the grid and observe the evolution of cell states.

To run the Conway's Game of Life simulation, you need to first clone the repository containing the project files. After cloning the repository, you can open the project in Unity, which is required to run the simulation[1]. Once the project is open in Unity, you can press the Play button to start the simulation. During the simulation, you can use the Space key to manually update the grid and observe how the cell states evolve over time.

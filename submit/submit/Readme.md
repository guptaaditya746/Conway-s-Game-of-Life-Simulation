# Conway's Game of Life Simulation

## Discussion

## Nassi-Shneiderman Diagrams

### Individual Automat Behavior
[Insert Nassi-Shneiderman diagram showing the logic for updating a single cell's state based on its neighbors' states]

This diagram outlines the algorithm for determining the next state of a cell based on the Game of Life rules. It checks the current state and the number of live neighbors to decide whether the cell will be alive or dead in the next generation.

### Overall Field Calculation
[Insert Nassi-Shneiderman diagram showing the logic for updating the entire grid of cells]

The overall field calculation diagram demonstrates how the simulation iterates through each cell in the grid, applying the rules to determine the next state of the entire population. It utilizes the individual automat behavior logic to update the state of each cell.

### Visualization
[Insert Nassi-Shneiderman diagram showing the process of rendering the cell states to the Unity UI]

This diagram depicts the process of visualizing the cell states in the Unity game engine. It involves updating the color and appearance of each cell's representation based on its current state (alive or dead).

## Class Diagrams

[Insert class diagram showing the structure and relationships between the key classes in your implementation]

The class diagram illustrates the main components of the simulation and their interactions. It includes the `Cell` class for managing individual cell states, the `GameOfLifeManager` class for handling the game logic and simulation loop, and the `GenerationDisplay` class for updating the UI with the current generation count.

## Simulation Results

### Pattern 1
[Insert screenshots of the simulation running Pattern 1 at generations 1, 5, 10, 20, and 50]

The simulation results for Pattern 1 show how the initial configuration evolves over multiple generations, demonstrating the emergent behavior of the cellular automata.

### Pattern 2
[Insert screenshots of the simulation running Pattern 2 at generations 1, 5, 10, 20, and 50]

The simulation results for Pattern 2 illustrate a different initial pattern and its evolution, highlighting the diversity of outcomes that can arise from varying starting conditions.

### Pattern 3
[Insert screenshots of the simulation running Pattern 3 at generations 1, 5, 10, 20, and 50]

The simulation results for Pattern 3 provide insights into the complex and often unpredictable nature of the Game of Life, as the population undergoes changes and reaches different stable or oscillating states over time.

By including these diagrams and simulation screenshots, your project report will provide a comprehensive overview of your implementation, showcasing your understanding of the problem and the techniques used to create the Conway's Game of Life simulation in Unity.

Citations:
[1] https://www.edrawsoft.com/template-nassi-shneiderman-diagram.html
[2] https://www.edrawsoft.com/nassi-schneiderman.html
[3] https://www.breezetree.com/articles/nassi-shneiderman-diagram
[4] https://typst.app/universe/package/nassi/
[5] https://en.wikipedia.org/wiki/Nassi%E2%80%93Shneiderman_diagram

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

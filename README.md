# BTG_AI_PCT3
Anass Baattite  El Oufir Abderrahmane |
CSC 4301 01 |
Spring 2022

Report Project 3
The Ghost Buster game requires you to click on one of the cells in the 8x20 grid and behave in accordance with the color of the cell. If it's green, that means you're at least 5 cells away from the ghost. When you are 3 or 4 cells apart, the yellow color appears. And the orange color shows when you are 1 or 2 cells away from it. When you click on the cell with the ghost, the final color, red, appears. Different probabilities are updated each time you click on a cell in the game. That is how the player can win by finding the cell with the ghost.
The main scripts we used to develop the game are:
Game.cs:
	This script contains all the main function of the game. It is responsible for randomly placing the ghost, showing the colors, and calculating the distance between the ghost and where the player clicked.
-	displayed_color(): This function is responsible for placing the different colors according to the placement of the ghost.
-	JointTableProbability(): This function is responsible for placing the right color in the right cells. It calculates the probability using the distance and the colors.
-	CheckInputGrid(): This function handles all the probabilities of the game using Bayesian inference.

Tile.cs: 
	This script hold all the variables that we used for the grid.

WinLose.cs:
	This script handles the win or the loss situations.

ProbabilityText.cs:
This script is responsible for displaying the probability and updating them after each click of the player.

Finally, we learned a lot from this project, particularly about probability and how to handle colors in order to win a game. The player clicks on the cells of his choice, and the probabilities update based on the position of the ghost. The player can easily conquer the game if he follows the colors and higher probabilities, and if he finds a probability of 1, he can catch the ghost and win the game.
Here is the link of the working demo: https://youtu.be/4TEkYgsVUXU
 
 

 


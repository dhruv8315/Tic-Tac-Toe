# Tic Tac Toe Game

This is a simple Tic Tac Toe game developed in C# using the .NET GUI framework. The game allows one player to play against CPU on a 3x3 grid. Player take turn marking a space on the grid, with the goal of getting three of their symbols in a row, either horizontally, vertically, or diagonally.

## Getting Started

To run the Tic Tac Toe game, you need to have the following prerequisites installed on your system:

- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework)
- Visual Studio or any other C# development environment

## Installation

1. Clone the repository or download the source code files.
2. Open the project in Visual Studio or your preferred C# development environment.

## How to Play

1. Build and run the project to start the game.
2. The game will display a 3x3 grid on the screen.
3. Player will be assigned the symbol 'X' and CPU will be assigned the symbol 'O'.
4. Player will take turns selecting an empty space on the grid to mark with their symbol.
5. The game will automatically determine the winner or declare a draw when there are three symbols of the same kind in a row, or when all spaces on the grid have been filled.
6. At the end of the game, a dialog box will appear asking if you want to play again. You can choose to start a new game or exit the application.

## File Structure

- `Program.cs`: Contains the main entry point of the application.
- `Form1.cs`: Represents the game board and handles the logic for checking the winner.
- `Player.cs`: Represents a player and stores their symbol and turn.
- `GameForm.cs`: The main form of the application, handles user input and updates the UI.

## Contributing

Contributions to this Tic Tac Toe game are welcome. If you find any bugs or have suggestions for improvements, feel free to submit an issue or pull request.

## License

This project is licensed under the [MIT License](LICENSE).

## Acknowledgments

This Tic Tac Toe game was developed as a learning project and is based on the classic game of Tic Tac Toe.

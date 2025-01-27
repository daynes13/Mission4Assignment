using Mission4Assignment;

public class Program
{
    public static void Main()
    {
        Supporting s = new Supporting();

        char[,] board =
        {
        {'1','2','3'},
        {'4','5','6'},
        {'7','8','9'}
    };
        string position;
        bool player1 = true;
        int moves = 0;

        Console.WriteLine("Welcome to our Tic-Tac-Toe game!");
        Console.WriteLine("Let's play!");
        Console.WriteLine("Enter the number in the grid to fill that space.");
        s.printBoard(board);

        // Playing the game
        while (!Supporting.checkWinner(board) && moves < 9)
        {
            Console.WriteLine($"Here's your current board. Player {(player1 ? "1 (X)" : "2 (O)")}, enter a number to fill that space:");
            position = Console.ReadLine();

            // Keep prompting for input until the move is valid
            while (!fillBoard(board, position, player1))
            {
                Console.WriteLine("Invalid move. Please try again.");
                position = Console.ReadLine();  // Prompt again for a valid move
            }

            player1 = !player1;  // Switch players only after a valid move
            moves++;
            s.printBoard(board); // Print the board after a valid move
        }

        if (Supporting.checkWinner(board))
        {
            Console.WriteLine($"{Supporting.declareWinner(board)} wins!");
        }
        else
        {
            Console.WriteLine("It's a tie! The board is full.");
        }
    }


    public static bool fillBoard(char[,] board, string input, bool player1)
    {
        bool isValidMove = false;  // Initialize the variable to track the validity of the move
        char value = player1 ? 'X' : 'O';

        if (int.TryParse(input, out int position) && position >= 1 && position <= 9)
        {
            int row = (position - 1) / 3;
            int col = (position - 1) % 3;

            if (board[row, col] != 'X' && board[row, col] != 'O')
            {
                board[row, col] = value;  // Place the value
                isValidMove = true;        // Set to true if the move is valid
            }
            else
            {
                Console.WriteLine("That spot is already taken. Try again.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
        }

        return isValidMove;  // Return the validity of the move at the end
    }
}
    

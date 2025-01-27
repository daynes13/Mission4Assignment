using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4Assignment
{
    internal class Supporting
    {
        public void printBoard(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                string line = "";
                
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    line += board[i, j] + " | ";
                }
                Console.WriteLine(line);
            }
        }

        public static bool checkWinner(char[,] board)
        {
            //declare the middle of the board as a variable
            char middle = board[1,1];
            char topLeft = board[0,0];
            char bottomRight = board[2,2];
            
            
            //checks for the winner
            //vertical
            if (board[1,0] == topLeft && board[2,0] == topLeft)
            {
                return true;
            }
            
            else if (board[0,1] == middle && board[2,1] == middle)
            {
                return true;
            }
            
            else if (board[0,2] == bottomRight && board[1,2] == bottomRight)
            {
                return true;
            }
            
            //horizontal
            else if (board[0,1] == topLeft && board[0,2] == topLeft)
            {
                return true;
            }
            
            else if (board[1,0] == middle && board[1,2] == middle)
            {
                return true;
            }
            
            else if (board[2,0] == bottomRight && board[2,1] == bottomRight)
            {
                return true;
            }
            
            //diagonal
            else if (board[0,0] == middle && board[2,2] == middle)
            {
                return true;
            }
            
            else if (board[0,2] == middle && board[2,0] == middle)
            {
                return true;
            }
            //no winner
            else
            {
                return false;
            }
            
        }
        
        public static string declareWinner(char[,] board)
        {
            //declare the middle of the board as a variable
            char middle = board[1,1];
            char topLeft = board[0,0];
            char bottomRight = board[2,2];
            string winner = "";
            
            //checks for the winner
            //vertical
            if (board[1,0] == topLeft && board[2,0] == topLeft)
            {
                winner = topLeft.ToString();
            }
            
            else if (board[0,1] == middle && board[2,1] == middle)
            {
                winner = middle.ToString();
            }
            
            else if (board[0,2] == bottomRight && board[1,2] == bottomRight)
            {
                winner = bottomRight.ToString();
            }
            
            //horizontal
            else if (board[0,1] == topLeft && board[0,2] == topLeft)
            {
                winner = topLeft.ToString();
            }
            
            else if (board[1,0] == middle && board[1,2] == middle)
            {
                winner = middle.ToString();
            }
            
            else if (board[2,0] == bottomRight && board[2,1] == bottomRight)
            {
                winner = bottomRight.ToString();
            }
            
            //diagonal
            else if (board[0,0] == middle && board[2,2] == middle)
            {
                winner = middle.ToString();
            }
            
            else if (board[0,2] == middle && board[2,0] == middle)
            {
                winner = middle.ToString();
            }

            if (winner == "X")
            {
                return "Player 1";
            }
            else return "Player 2";
            }
              
    }
}

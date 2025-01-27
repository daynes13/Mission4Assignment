using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4Assignment
{
    internal class Supporting
    {
        public void printBoard(string[] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                string line = "";
                
                for (int j = 0; j < board[i].Length; j++)
                {
                    line += board[i][j] + " |";
                }
                Console.WriteLine(line);
            }
        }

        public static bool checkWinner(string[][] board)
        {
            //declare the middle of the board as a variable
            string middle = board[1][1];
            string topLeft = board[0][0];
            string bottomRight = board[2][2];
            
            
            //checks for the winner
            //vertical
            if (board[1][0] == topLeft && board[2][0] == topLeft)
            {
                return true;
            }
            
            else if (board[0][1] == middle && board[2][1] == middle)
            {
                return true;
            }
            
            else if (board[0][2] == bottomRight && board[1][2] == bottomRight)
            {
                return true;
            }
            
            //horizontal
            else if (board[0][1] == topLeft && board[0][2] == topLeft)
            {
                return true;
            }
            
            else if (board[1][0] == middle && board[1][2] == middle)
            {
                return true;
            }
            
            else if (board[2][0] == bottomRight && board[2][1] == bottomRight)
            {
                return true;
            }
            
            //diagonal
            else if (board[0][0] == middle && board[2][2] == middle)
            {
                return true;
            }
            
            else if (board[0][2] == middle && board[2][0] == middle)
            {
                return true;
            }
            //no winner
            else
            {
                return false;
            }
            
        }
        
        public static string declareWinner(string[][] board)
        {
            //declare the middle of the board as a variable
            string middle = board[1][1];
            string topLeft = board[0][0];
            string bottomRight = board[2][2];
            string winner = "";
            
            //checks for the winner
            //vertical
            if (board[1][0] == topLeft && board[2][0] == topLeft)
            {
                winner = topLeft;
            }
            
            else if (board[0][1] == middle && board[2][1] == middle)
            {
                winner = middle;
            }
            
            else if (board[0][2] == bottomRight && board[1][2] == bottomRight)
            {
                winner = bottomRight;
            }
            
            //horizontal
            else if (board[0][1] == topLeft && board[0][2] == topLeft)
            {
                winner = topLeft;
            }
            
            else if (board[1][0] == middle && board[1][2] == middle)
            {
                winner = middle;
            }
            
            else if (board[2][0] == bottomRight && board[2][1] == bottomRight)
            {
                winner = bottomRight;
            }
            
            //diagonal
            else if (board[0][0] == middle && board[2][2] == middle)
            {
                winner = middle;
            }
            
            else if (board[0][2] == middle && board[2][0] == middle)
            {
                winner = middle;
            }

            if (winner == "X")
            {
                return "player1";
            }
            else if (winner == "O")
            {
                return "player2";
            }
        }
        
        
        
    }
}

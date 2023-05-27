

namespace TicTacToe
{
    class Program
    {


        static char[] boardSquares = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
        static int player = 1; // Set Player 1
        static int userChoice;
        // The flag variable checks who has won if it's value is 1 then someone has won the match
        //if -1 then Match has Draw if 0 then match is still running
        static int flag = 0; 

        public static void Main(string[] args)
        {
            do
            {
                Console.Clear(); 
            System.Console.WriteLine("WELCOME TO TIC TAC TOE");

            System.Console.WriteLine("Player 1: X's || Player 2: O's");
            System.Console.WriteLine("\n");
            if (player % 2 == 0)// checking player turn
            {
                System.Console.WriteLine("Player 2's Turn'");
            }
            else
            {
                System.Console.WriteLine("Player 1's Turn'");
            }
            System.Console.WriteLine("\n");
            Board();
            userChoice = int.Parse(Console.ReadLine()); // Taking user's choice
            // checking that position where user want to run is marked (with X or O) or not
            if (boardSquares[userChoice] != 'X' && boardSquares[userChoice] != 'O')
            {
                if (player % 2 == 0) //If player 2's turn, mark "O" else mark "X"
                {
                    boardSquares[userChoice] = 'O';
                    player++;
                }
                else
                {
                    boardSquares[userChoice] = 'X';
                    player++;
                }
            }
            else

            {

                System.Console.WriteLine($"You dingus, {userChoice} is occupied with {boardSquares[userChoice]}. Try again.");
                System.Console.WriteLine("\n");
                System.Console.WriteLine("Board loading...");
                Thread.Sleep(2000);
            }
            flag = CheckWin();// calling Win Check
        }
        while (flag != 1 && flag != -1);
            
            Console.Clear();
            Board();// getting filled board again

            if (flag == 1)
            // whoever's turn it was last will be considered winner
            {
                System.Console.WriteLine($"Player {(player % 2) + 1}");

            }
            else // game ends in draw
            {
                System.Console.WriteLine("Draw!");
            }
            Console.ReadLine();
        }

        // Create board
        private static void Board()
        {
            Console.WriteLine($"     |     |      ");
            Console.WriteLine($"  {boardSquares[7]}  |  {boardSquares[8]}  |  {boardSquares[9]}");
            Console.WriteLine($"_____|_____|_____ ");
            Console.WriteLine($"     |     |      ");
            Console.WriteLine($"  {boardSquares[4]}  |  {boardSquares[5]}  |  {boardSquares[6]}");
            Console.WriteLine($"_____|_____|_____ ");
            Console.WriteLine($"     |     |      ");
            Console.WriteLine($"  {boardSquares[1]}  |  {boardSquares[2]}  |  {boardSquares[3]}");
            Console.WriteLine($"     |     |      ");
        }

        //Checking if a player has won
        private static int CheckWin()
        {
            #region Horizontal Winning Condition


            //Winning condition for bottom row
            if (boardSquares[1] == boardSquares[2] && boardSquares[2] == boardSquares[3])
            {
                return 1;
            }
            //Winning condition for middle row
            else if (boardSquares[4] == boardSquares[5] && boardSquares[5] == boardSquares[6])
            {
                return 1;
            }
            //Winning condition for top row
            // initially code was 6 == 7 == 8 but pretty sure it's 7==8==9
            else if (boardSquares[7] == boardSquares[8] && boardSquares[8] == boardSquares[9])
            {
                return 1;
            }
            #endregion

            #region Vertical Winning Condition
            //Winning Condition for Left Column
            if (boardSquares[1] == boardSquares[4] && boardSquares[4] == boardSquares[7])
            {
                return 1;
            }
            //Winning Condition for Middle Column
            else if (boardSquares[2] == boardSquares[5] && boardSquares[5] == boardSquares[8])
            {
                return 1;
            } 
            //Winning Condition for Right Column
            else if (boardSquares[3] == boardSquares[6] && boardSquares[6] == boardSquares[9])
            {
                return 1;
            }
            #endregion

            #region Diagonal Winning Condition

            if (boardSquares[7] == boardSquares[5] && boardSquares[5] == boardSquares[3])
            {
                return 1;
            }
            else if (boardSquares[1] == boardSquares[5] && boardSquares[5] == boardSquares[9])
            {
                return 1;
            }
            #endregion

            #region Checking for Draw
            //If all cells are filled, Draw

            if (boardSquares[1] != '1' && boardSquares[2] != '2' && boardSquares[3] != '3' && boardSquares[4] != '4' && boardSquares[5] != '5' && boardSquares[6] != '6' && boardSquares[7] != '7' && boardSquares[8] != '8' && boardSquares[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }

        public enum BoardSquares
        {
            One,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine
        }

        public enum SquareStates
        {
            X,
            O,
            empty
        }
    }
}



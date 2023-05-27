namespace RockPaperScissors
{
     class Program
     {
          // Class level variables to use player inputs in several spots
          static int player1Wins = 0;
          static int player2Wins = 0;

          public static void Main(string[] args)
          {
               // Title 
               System.Console.WriteLine("Welcome to Rock-Paper-Scissors");

               while (true)
               {

                    // reset player inputs 
                    int player1Input = 0;
                    int player2Input = 0;


                    // Gather Player 1 Answer
                    player1Input = PromptPlayer1();

                    // Set Main variables using methods that pass player inputs
                    var player1Choice = SetChoicePlayer1(player1Input);




                    // Gather Player 2 Answer

                    player2Input = PromptPlayer2();

                    // Set Main variables using methods that pass player inputs

                    var player2Choice = SetChoicePlayer2(player2Input);

                    

                    GameLogic(player1Input, player2Input, player1Choice, player2Choice);

                    

               }
          }


          public static bool GameLogic(int player1Input, int player2Input, Player1Choice player1Choice, Player2Choice player2Choice)
          {
               // IF logic to determine winner


                    if (player1Input == player2Input)
                    {
                         System.Console.WriteLine("Tie game!");
                    }

                    else if ((player1Choice == Player1Choice.Rock && player2Choice == Player2Choice.Scissors) 
                    || (player1Choice == Player1Choice.Paper && player2Choice == Player2Choice.Rock) 
                    || (player1Choice == Player1Choice.Scissors && player2Choice == Player2Choice.Paper))
                    {
                         System.Console.WriteLine("Player One Wins!");
                         player1Wins++;
                    }

                    else
                    {
                         System.Console.WriteLine("Player Two Wins!");
                         player2Wins++;
                    }

                    System.Console.WriteLine($"Player 1 has won {player1Wins} times and Player 2 has won {player2Wins} times!");

                    System.Console.WriteLine("Press any key to play again, or enter 'q' to end the program.");
                    var keyInput = Console.ReadKey();
                    if (keyInput.KeyChar == 'q')
                    {
                         return false;
                    }

               return true;
          }


          public static int PromptPlayer1()
          {
               System.Console.WriteLine("Player 1, enter your NUMBER choice of 1. Rock, 2. Paper, or 3. Scissors: ");
               int player1Input = Convert.ToInt32(Console.ReadLine());
               // Console.Clear();
               // commenting out .Clear() for now
               return player1Input;
          }

          public static Player1Choice SetChoicePlayer1(int player1Input)
          {
               switch (player1Input)
               {
                    case 1:
                    return Player1Choice.Rock;

                    case 2:
                    return Player1Choice.Paper;

                    case 3:
                    return Player1Choice.Scissors;

                    default:
                    throw new ArgumentException("Invalid input, try again partner.");

               }
          }

          public static int PromptPlayer2()
          {
               System.Console.WriteLine("Player 2, enter your NUMBER choice of 1. Rock, 2. Paper, or 3. Scissors: ");
               int player2Input = Convert.ToInt32(Console.ReadLine());
               // Console.Clear();
               // commenting out .Clear() for now
               return player2Input;
          }

          public static Player2Choice SetChoicePlayer2(int player2Input)
          {
               switch (player2Input)
               {
                    case 1:
                    return Player2Choice.Rock;

                    case 2:
                    return Player2Choice.Paper;

                    case 3:
                    return Player2Choice.Scissors;

                    default:
                    throw new ArgumentException("Invalid input, try again partner.");

               }
          }
     }

     public enum Player1Choice
     {
          Rock,
          Paper,
          Scissors
     }

     public enum Player2Choice
     {
          Rock,
          Paper,
          Scissors
     }

     public enum GameWinner
     {
          PlayerOne,
          PlayerTwo
     }
}

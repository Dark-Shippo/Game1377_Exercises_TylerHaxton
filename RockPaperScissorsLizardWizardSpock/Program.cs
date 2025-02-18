using System.Runtime.ExceptionServices;

namespace RockPaperScissorsLizardWizardSpock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerWinCount = 0;
            int opponentWinCount = 0;
            PlayerInput(playerWinCount, opponentWinCount);
        }

        static void PlayerInput(int playerWinCount, int opponentWinCount)
        {
            string[] choicesList = { "rock", "paper", "scissors", "lizard", "spock" };
            string? roundStart = "Please choose Rock, Paper, Scissors, Lizard, or Spock.";
            Dictionary<string, List<string>> winConditions = new Dictionary<string, List<string>>()
            {
                { "rock", new List<string> { "scissors", "lizard" } },
                { "paper", new List<string> { "rock", "spock" } },
                { "scissors", new List<string> { "paper", "lizard" } },
                { "lizard", new List<string> { "paper", "spock" } },
                { "spock", new List<string> { "scissors", "rock" } }
            };

            bool isPlaying = true;
            int playerRoundWinCount = 0;
            int opponentRoundWinCount = 0;

            while (isPlaying)
            {
                Console.WriteLine("\n" + "First to five wins." + "\n" + roundStart);
                string? userInput = Console.ReadLine()?.Trim().ToLower();

                if (!Array.Exists(choicesList, choice => choice.Equals(userInput, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine("Invalid choice!.");
                    continue;
                }

                Random rand = new Random();
                string opponentChoice = choicesList[rand.Next(choicesList.Length)];

                Console.WriteLine($"Opponent chose: {opponentChoice}");

                if (winConditions[userInput].Contains(opponentChoice))
                {
                    Console.WriteLine("You win this round!");
                    playerRoundWinCount++;
                }
                else if (userInput.Equals(opponentChoice, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("It's a tie!");
                }
                else if (winConditions[opponentChoice].Contains(userInput))
                {
                    Console.WriteLine("Your Opponent wins this round!");
                    opponentRoundWinCount++;
                }
                else
                {
                    Console.WriteLine("It's a tie! No points awarded");
                }

                Console.WriteLine($"Score - Player {playerRoundWinCount}, Opponent {opponentRoundWinCount}");

                if (playerRoundWinCount == 5 || opponentRoundWinCount == 5)
                {
                    if (playerRoundWinCount == 5)
                    {
                        Console.WriteLine("You WIN!");
                        playerWinCount++;
                        isPlaying = false;
                    }
                    else if (opponentRoundWinCount == 5)
                    {
                        Console.WriteLine("Your Opponent WINS!");
                        opponentWinCount++;
                        isPlaying = false;
                    }
                }
            }

            if (!isPlaying)
            {
                Console.WriteLine($"You have won {playerWinCount} times." + "\n" + 
                    $"The Opponent has won {opponentWinCount} times." + "\n" + 
                    "If you win to play again press Y or press N to quit.");
                var input = Console.ReadKey();
                switch(input.Key)
                {
                    case (ConsoleKey.Y):
                        isPlaying = true;
                        PlayerInput(playerWinCount, opponentWinCount);
                        break;
                    case (ConsoleKey.N):
                        Console.WriteLine("Goodbye and Thanks for playing");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }
           }
        }
    }
}

using System;

namespace RockPaperScissors.ConsoleApp
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("How many rounds?");
            var noOfRounds = Convert.ToInt32(Console.ReadLine());

            var playerOne = Player.Human(name, ConsoleMoveStrategy(new ConsoleLogger()));
            var playerTwo = Player.Computer(new ConsoleLogger());

            var game = new Game(playerOne, playerTwo, noOfRounds);

            for (var i = 0; i < noOfRounds; i++)
            {
                Console.WriteLine(DisplayUi(name, "AI", noOfRounds, i));

                var winnerOfRound = game.PlayRound();
                Console.WriteLine($"{winnerOfRound} wins the round");
                Console.ReadLine();
            }

            var winnerOfGame = game.Winner();
            Console.WriteLine($"{winnerOfGame} wins the game");
            Console.ReadLine();
        }

        public static string DisplayUi(string playerOneName, string playerTwoName, int numberOfRounds, int currentRound)
        {
            return $"PLAYER ONE      | PLAYER TWO      |    CURRENT ROUND |   MAX ROUNDS" + Environment.NewLine +
                   $"{playerOneName} | {playerTwoName} | {numberOfRounds} | {currentRound}" + Environment.NewLine;
        }

        public static Func<HandShape> ConsoleMoveStrategy(ILogger logger)
        {
                logger.Log("Rock, Paper, Scissors?");
                var handMove = Console.ReadLine();
                var handShape = HandShape.From(handMove);
                logger.Log($"Human chose {handMove}");
                return handShape;
        }
    }
}

namespace Minesweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Minesweeper
    {
        public static void Main(string[] arguments)
        {
            string command = string.Empty;
            char[,] field = CreateGameField();
            char[,] bombs = PlaceBombs();
            int counter = 0;
            bool isBomb = false;
            List<Score> topScore = new List<Score>(6);
            int row = 0;
            int cow = 0;
            bool isNewGame = true;
            const int MaxPoints = 35;
            bool isWon = false;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine("Lets play Mines. Try your luck and find all fields without mines.");
                    Console.WriteLine("Console comands:");
                    Console.WriteLine("top - Shows player chart");
                    Console.WriteLine("restart - Start new game, ");
                    Console.WriteLine("exit");
                    GameField(field);
                    isNewGame = false;
                }

                Console.Write("Enter row amd colum : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out cow) &&
                        row <= field.GetLength(0) && cow <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        Chart(topScore);
                        break;
                    case "restart":
                        field = CreateGameField();
                        bombs = PlaceBombs();
                        GameField(field);
                        isBomb = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Good buy!");
                        break;
                    case "turn":
                        if (bombs[row, cow] != '*')
                        {
                            if (bombs[row, cow] == '-')
                            {
                                SurroundingBombCount(field, bombs, row, cow);
                                counter++;
                            }

                            if (MaxPoints == counter)
                            {
                                isWon = true;
                            }
                            else
                            {
                                GameField(field);
                            }
                        }
                        else
                        {
                            isBomb = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nErrpr: Incorect command!\n");
                        break;
                }

                if (isBomb)
                {
                    GameField(bombs);
                    Console.WriteLine("GameOver!");
                    Console.WriteLine("Your points: {0}", counter);
                    Console.WriteLine("Enter your NikName: ");
                    string playerName = Console.ReadLine();
                    Score playerPoints = new Score(playerName, counter);
                    if (topScore.Count < 5)
                    {
                        topScore.Add(playerPoints);
                    }
                    else
                    {
                        for (int i = 0; i < topScore.Count; i++)
                        {
                            if (topScore[i].Points < playerPoints.Points)
                            {
                                topScore.Insert(i, playerPoints);
                                topScore.RemoveAt(topScore.Count - 1);
                                break;
                            }
                        }
                    }

                    topScore.Sort((Score firstPlayer, Score secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    topScore.Sort((Score firstPlayer, Score secondPlayer) => secondPlayer.Points.CompareTo(firstPlayer.Points));
                    Chart(topScore);
                    field = CreateGameField();
                    bombs = PlaceBombs();
                    counter = 0;
                    isBomb = false;
                    isNewGame = true;
                }

                if (isWon)
                {
                    Console.WriteLine("\nYOU WON!!!\n You have opened all {0} fields.", MaxPoints);
                    GameField(bombs);
                    Console.WriteLine("Enter your Name: ");
                    string playerName = Console.ReadLine();
                    Score playerPoints = new Score(playerName, counter);
                    topScore.Add(playerPoints);
                    Chart(topScore);
                    field = CreateGameField();
                    bombs = PlaceBombs();
                    counter = 0;
                    isWon = false;
                    isNewGame = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void Chart(List<Score> playerPoints)
        {
            Console.WriteLine("\nPoints:");
            if (playerPoints.Count > 0)
            {
                for (int i = 0; i < playerPoints.Count; i++)
                {
                    Console.WriteLine(
                        "{0}. {1} --> {2} Filds opend",
                        i + 1,
                        playerPoints[i].Name,
                        playerPoints[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty!\n");
            }
        }

        private static void SurroundingBombCount(char[,] field, char[,] bombs, int row, int col)
        {
            char bombsNumber = GetSurroundingBombCount(bombs, row, col);
            bombs[row, col] = bombsNumber;
            field[row, col] = bombsNumber;
        }

        private static void GameField(char[,] board)
        {
            int row = board.GetLength(0);
            int col = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < row; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < col; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceBombs()
        {
            int fieldRows = 5;
            int fieldCols = 10;
            char[,] bombField = new char[fieldRows, fieldCols];

            for (int i = 0; i < fieldRows; i++)
            {
                for (int j = 0; j < fieldCols; j++)
                {
                    bombField[i, j] = '-';
                }
            }

            List<int> bombMap = new List<int>();
            while (bombMap.Count < 15)
            {
                Random random = new Random();
                int asfd = random.Next(50);
                if (!bombMap.Contains(asfd))
                {
                    bombMap.Add(asfd);
                }
            }

            foreach (int bombLocation in bombMap)
            {
                int col = bombLocation / fieldCols;
                int row = bombLocation % fieldCols;

                if (row == 0 && bombLocation != 0)
                {
                    col--;
                    row = fieldCols;
                }
                else
                {
                    row++;
                }

                bombField[col, row - 1] = '*';
            }

            return bombField;
        }

        private static char GetSurroundingBombCount(char[,] bombField, int row, int col)
        {
            int bombCounter = 0;
            int rowCount = bombField.GetLength(0);
            int colCount = bombField.GetLength(1);

            if (row - 1 >= 0)
            {
                if (bombField[row - 1, col] == '*')
                {
                    bombCounter++;
                }
            }

            if (row + 1 < rowCount)
            {
                if (bombField[row + 1, col] == '*')
                {
                    bombCounter++;
                }
            }

            if (col - 1 >= 0)
            {
                if (bombField[row, col - 1] == '*')
                {
                    bombCounter++;
                }
            }

            if (col + 1 < colCount)
            {
                if (bombField[row, col + 1] == '*')
                {
                    bombCounter++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (bombField[row - 1, col - 1] == '*')
                {
                    bombCounter++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < colCount))
            {
                if (bombField[row - 1, col + 1] == '*')
                {
                    bombCounter++;
                }
            }

            if ((row + 1 < rowCount) && (col - 1 >= 0))
            {
                if (bombField[row + 1, col - 1] == '*')
                {
                    bombCounter++;
                }
            }

            if ((row + 1 < rowCount) && (col + 1 < colCount))
            {
                if (bombField[row + 1, col + 1] == '*')
                {
                    bombCounter++;
                }
            }

            return char.Parse(bombCounter.ToString());
        }
    }
}

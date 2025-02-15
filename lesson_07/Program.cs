//Потрібно розробити консольну гру "Хрестики Нолики" з використанням мови програмування C#.
//Створіть ігрове поле, де два гравці будуть чергово робити ходи і ставити свої знаки ("X" або "O") в вільні клітинки.
//Гра повинна тривати до тих пір, поки один із гравців не виграє, заповнивши вертикалі, горизонталі або діагоналі трьома своїми знаками підряд, або до настання нічиєї.

//Вимоги:

//Використовуйте мову програмування C# для реалізації гри.
//Створіть ігрове поле розміром 3x3, де кожна клітинка позначена числом від 1 до 9.
//Реалізуйте механізм чергових ходів двох гравців. Перший гравець розміщує "X", другий - "O".
//Перевірте кожен хід на наявність виграшної комбінації або наступ нічиєї.
//Після кожного ходу виведіть поточний стан ігрового поля на консоль.

string emptySymbol = "?";
int boardSize = 5;
int winCondition = 3;
string boardLinesSeparator = getBoardLinesSeparator(boardSize);
var players = new[]
{
    new {
        symbol = "X",
        name = "Alex"
    },
    new {
        symbol = "O",
        name = "Bob"
    }
};
string[,] board = new string[boardSize, boardSize];

fillEmptyBoard();
drawBoard();
nextMove(0);

string getBoardLinesSeparator(int size)
{
    string separator = string.Empty;
    int separatorLength = size * 2 - 1;

    for (int i = 0; i < separatorLength; i++)
    {
        separator += "-";
    }

    return separator;
}

void fillEmptyBoard()
{
    for (int i = 0; i < board.GetLength(0); i++)
    {
        for (int j = 0; j < board.GetLength(1); j++)
        {
            board[i, j] = emptySymbol;
        }
    }
}

void drawBoard()
{
    Console.Clear();

    for (int i = 0; i < board.GetLength(0); i++)
    {
        for (int j = 0; j < board.GetLength(1); j++)
        {
            string separator = " ";

            if ((board.GetLength(1) - 1) == j)
            {
                separator = "";
            }

            Console.Write($"{board[i, j]}{separator}");
        }

        Console.WriteLine("");
        Console.WriteLine($"{boardLinesSeparator}");
    }
}

void nextMove(int playerIndex)
{
    var player = players[playerIndex];
    var move = getPlayerMove(player.name);
    updateBoard(player.symbol, move);
    drawBoard();
    bool isWon = getIsWon(player.symbol);

    if (isWon)
    {
        Console.WriteLine($"Player {player.name} won!");
        return;
    }

    bool isEmptyCell = getIsEmptyCell();

    if (!isEmptyCell)
    {
        Console.WriteLine("Draw!");
        return;
    }

    nextMove(getNextPlayerIndex(playerIndex));
}

bool getIsEmptyCell()
{
    bool isEmpty = false;

    foreach (string cell in board)
    {
        if (cell == emptySymbol)
        {
            isEmpty = true;
            break;
        }
    }

    return isEmpty;
}

(int x, int y) getPlayerMove(string name)
{
    int x = 0;
    int y = 0;

    do
    {
        x = getPlayerCoordinate("x", name);
        y = getPlayerCoordinate("y", name);
    } while (!isCellEmpty(x, y));

    return (x, y);
}

int getPlayerCoordinate(string coordinateName, string name)
{
    int coordinate = 0;

    do
    {
        Console.WriteLine($"{name}! Enter {coordinateName} coordinate from 1 to {boardSize}");
    } while (!int.TryParse(Console.ReadLine(), out coordinate) || coordinate < 1 || coordinate > boardSize);

    return coordinate;
}

bool isCellEmpty(int x, int y)
{
    return board[y - 1, x - 1] == emptySymbol;
}

void updateBoard(string symbol, (int x, int y) move)
{
    board[move.y - 1, move.x - 1] = symbol;
}

int getNextPlayerIndex(int prevIndex)
{
    if (prevIndex >= (players.Length - 1))
    {
        return 0;
    }

    return prevIndex + 1;
}

bool getIsWon(string symbol)
{
    bool isRowMatch = getIsLineMatch(symbol, "row");
    bool isColMatch = getIsLineMatch(symbol, "col");
    bool isDiagonalMatch = getIsDiagonalMatch(symbol);

    return isRowMatch || isColMatch || isDiagonalMatch;
}

bool getIsLineMatch(string symbol, string strategy)
{
    int maxMatch = 0;

    for (int i = 0; i < boardSize; i++)
    {
        int currentMatch = 0;

        for (int j = 0; j < boardSize; j++)
        {
            string currentSymbol = strategy == "row" ? board[i, j] : board[j, i];
            bool isMatch = currentSymbol == symbol;

            if (isMatch)
            {
                currentMatch++;

                if (currentMatch > maxMatch)
                {
                    maxMatch = currentMatch;
                }
            } else
            {
                currentMatch = 0;
            }
        }
    }

    return maxMatch >= winCondition;
}

bool getIsDiagonalMatch(string symbol)
{
    bool isPrimaryDiagonalMatch = getIsPrimaryDiagonalMatch(symbol);
    bool isSecondaryDiagonalMatch = getIsSecondaryDiagonalMatch(symbol);
    bool isAdditionalDiagonalsMatch = getIsAdditionalDiagonalsMatch(symbol);

    return isPrimaryDiagonalMatch || isSecondaryDiagonalMatch || isAdditionalDiagonalsMatch;
}

bool getIsPrimaryDiagonalMatch(string symbol)
{
    int maxMatch = 0;
    int currentMatch = 0;

    for (int i = 0; i < boardSize; i++)
    {
        bool isMatch = board[i, i] == symbol;

        if (isMatch)
        {
            currentMatch++;

            if (currentMatch > maxMatch)
            {
                maxMatch = currentMatch;
            }
        }
        else
        {
            currentMatch = 0;
        }
    }

    return maxMatch >= winCondition;
}

bool getIsSecondaryDiagonalMatch(string symbol)
{
    int maxMatch = 0;
    int currentMatch = 0;

    for (int i = 0; i < boardSize; i++)
    {
        int j = boardSize - 1 - i;
        bool isMatch = board[i, j] == symbol;

        if (isMatch)
        {
            currentMatch++;

            if (currentMatch > maxMatch)
            {
                maxMatch = currentMatch;
            }
        }
        else
        {
            currentMatch = 0;
        }
    }

    return maxMatch >= winCondition;
}

bool getIsAdditionalDiagonalsMatch(string symbol)
{
    bool isMatchLTRDiagonals = getIsMatchLTRDiagonals(symbol);
    bool isMatchRTLDiagonals = getIsMatchRTLDiagonals(symbol);

    return isMatchLTRDiagonals || isMatchRTLDiagonals;
}

bool getIsMatchLTRDiagonals(string symbol)
{
    bool isLTRMatch = false;
    string[] directions = ["x", "y"];

    foreach(string direction in directions)
    {
        for (int offset = 1; offset <= (boardSize - winCondition); offset++)
        {
            int maxMatch = 0;
            int currentMatch = 0;
            int j = 0;

            for (int i = offset; i < boardSize; i++)
            {
                string currentSymbol = direction == "x" ? board[j, i] : board[i, j];
                bool isMatch = currentSymbol == symbol;

                if (isMatch)
                {
                    currentMatch++;

                    if (currentMatch > maxMatch)
                    {
                        maxMatch = currentMatch;
                    }
                }
                else
                {
                    currentMatch = 0;
                }

                j++;
            }

            if (maxMatch >= winCondition)
            {
                isLTRMatch = true;
                break;
            }
        }

        if (isLTRMatch)
        {
            break;
        }
    }

    return isLTRMatch;
}

bool getIsMatchRTLDiagonals(string symbol)
{
    bool isRTLMatch = false;

    for (int offset = 1; offset <= (boardSize - winCondition); offset++)
    {
        int maxMatch = 0;
        int currentMatch = 0;
        int j = boardSize - 1;

        for (int i = offset; i < boardSize; i++)
        {
            string currentSymbol = board[i, j];
            bool isMatch = currentSymbol == symbol;

            if (isMatch)
            {
                currentMatch++;

                if (currentMatch > maxMatch)
                {
                    maxMatch = currentMatch;
                }
            }
            else
            {
                currentMatch = 0;
            }

            j--;
        }

        if (maxMatch >= winCondition)
        {
            isRTLMatch = true;
            break;
        }
    }

    if (isRTLMatch)
    {
        return isRTLMatch;
    }

    for (int offset = 1; offset <= (boardSize - winCondition); offset++)
    {
        int maxMatch = 0;
        int currentMatch = 0;
        int j = 0;

        for (int i = (boardSize - 1 - offset); i >= 0; i--)
        {
            string currentSymbol = board[j, i];
            bool isMatch = currentSymbol == symbol;

            if (isMatch)
            {
                currentMatch++;

                if (currentMatch > maxMatch)
                {
                    maxMatch = currentMatch;
                }
            }
            else
            {
                currentMatch = 0;
            }

            j++;
        }

        if (maxMatch >= winCondition)
        {
            isRTLMatch = true;
            break;
        }
    }

    return isRTLMatch;
}

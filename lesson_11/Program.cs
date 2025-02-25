//Написати свій власний варіант гри “Шибениця”. Це гра, де треба вгадати посимвольно зашифроване слово. Нехай слово вже буде відомо програмі. Користувач може вводити по одній літері та має обмежену кількість невірних спроб.

using System.Text;

namespace lesson_11
{
    internal class Program
    {
        static void Main()
        {
            string word = "dooog";
            int attempts = 3;
            Game game = new Game(word, attempts);
            game.Start();
        }
    }

    public class Game
    {
        private readonly string _word;
        private int _attempts;
        private readonly List<LetterData> _game = [];

        public Game(string word, int attempts)
        {
            _word = word;
            _attempts = attempts;
            List<LetterData> newGame = [];

            for (int i = 0; i < _word.Length; i++)
            {
                newGame.Add(new LetterData(_word[i], i + 1));
            }

            _game = newGame;
        }

        public void Start()
        {
            if (_word.Length == 0 || _attempts <= 0)
            {
                Console.WriteLine(":(");
                return;
            }

            Console.WriteLine("Вітаємо! Спробуйте вгадати зашифроване слово!");
            Console.WriteLine($"Кількість літер у слові: {_word.Length}");
            Console.WriteLine($"Кількість можливих невірних спроб: {_attempts}\n");

            NextMove();
        }

        public void NextMove()
        {
            
            char inputChar;
            List<LetterData> openedLettersData = [];

            do
            {
                Console.WriteLine("Enter a letter:");
            } while (!char.TryParse(Console.ReadLine(), out inputChar));

            foreach (LetterData letterData in _game)
            {
                if (Char.ToLower(inputChar) == Char.ToLower(letterData.Letter) && !letterData.IsGuessed)
                {
                    letterData.IsGuessed = true;
                    openedLettersData.Add(letterData);
                }
            }

            if (openedLettersData.Count == 0)
            {
                _attempts--;

                if (_attempts == 0)
                {
                    Console.WriteLine($"Ви програли! Зашифроване слово: {_word}.");
                    return;
                }

                Console.WriteLine($"Такої літери немає! Залишилось спроб: {_attempts}");
                NextMove();
            }
            else
            {
                bool isWon = GetIsWon();
                StringBuilder positions = new();
                string separator = ", ";

                foreach (LetterData openedLetter in openedLettersData)
                {
                    if (positions.ToString() == "")
                    {
                        positions.Append(openedLetter.Position);
                    }
                    else
                    {
                        positions.Append($"{separator}{openedLetter.Position}");
                    }
                }

                if (isWon)
                {
                    Console.WriteLine($"\nВітаємо, ви вгадали слово! Зашифроване слово: {_word}.");
                    Console.WriteLine("Дякуємо за гру.");
                }
                else
                {
                    Console.WriteLine($"Така літера є у слові! Позиція літери: {positions}");
                    NextMove();
                }
            }
        }

        public bool GetIsWon()
        {
            bool isWon = true;

            foreach (LetterData letterData in _game)
            {
                if (!letterData.IsGuessed)
                {
                    isWon = false;
                    break;
                }
            }

            return isWon;
        }
    }

    public class LetterData
    {
        private readonly char _letter;
        private readonly int _position;
        private bool _isGuessed = false;

        public LetterData(char letter, int position)
        {
            _letter = letter;
            _position = position;
        }

        public char Letter
        {
            get { return _letter; }
        }

        public int Position
        {
            get { return _position; }
        }

        public bool IsGuessed
        {
            get { return _isGuessed; }
            set { _isGuessed = value; }
        }
    }
}

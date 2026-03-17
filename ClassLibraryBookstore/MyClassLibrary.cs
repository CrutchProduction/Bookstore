using System.Timers

namespace ClassLibraryBookstore
{
    public class MyClassLibrary
    {
        // Общие данные
        private static string[] labels;
        private static string[] authors;
        private static string[] genres;
        private static Shop myShop;

        // Очереди игры
        private static Queue clientsQueue;
        private static Queue booksPendingQueue;
        private static Queue booksArrivedQueue;

        // Параметры игры
        private static bool isGameStarted = false;
        private static int curGameDifficulty;

        // Константы
        private static readonly float[] difficultyDayTimes = {120, 240, 480};
        private static readonly float[] difficultyRndBookTimes = {10, 30, 60};
        private static readonly float[] difficultyClientTimes = {15, 20, 30};
        private static readonly float[] difficultyPenBookTimes = {15, 45, 75};
        private static readonly int[] maxClientsQueue = {7, 5, 3};

        // Конструктор
        public MyClassLibrary() {
            System.IO.File.WriteAllText("booksData.txt", "");
            loadData();
            myShop = new Shop();
            clientsQueue = new Queue();
            booksPendingQueue = new Queue();
            booksArrivedQueue = new Queue();
        }

        // Загрузка данных из файлов
        private static void loadData() {
            string[] rawData = System.IO.File.ReadAllLines("booksData.txt");
            for (int i = 0; i < rawData.Length; i++) {
                string[] curLineS = rawData[i].Split("|");

                labels[i] = curLineS[0];
                authors[i] = curLineS[1];
            }

            genres = System.IO.File.ReadAllText("genres.txt").Split(" ");
        }

        // Запуск цикла игры
        public static void startGame(int gameDifficulty) {
            curGameDifficulty = gameDifficulty;

            Timer gameTimer = new Timer(difficultyDayTimes[gameDifficulty] * 1000);
            gameTimer.Elapsed += stopGameEvent;
            gameTimer.Start();
            
            Timer randomBookArrive = new Timer(difficultyRndBookTimes[gameDifficulty] * 1000);
            randomBookArrive.Elapsed += randomBookArriveEvent;
            randomBookArrive.Start();
            
            Timer randomClientArrive = new Timer(difficultyClientTimes[gameDifficulty] * 1000);
            randomClientArrive.Elapsed += randomClientArriveEvent;
            randomClientArrive.Start();
            
            Timer pendingBookArrive = new Timer(difficultyPenBookTimes[gameDifficulty] * 1000);
            pendingBookArrive.Elapsed += pendingBookArriveEvent;

            isGameStarted = true;
            while (isGameStarted) {
                if (booksPendingQueue.Count == 0) {
                    pendingBookArrive.Start();
                } else {
                    pendingBookArrive.Stop();
                }


            }

            gameTimer.Stop();
            gameTimer.Dispose();

            randomBookArrive.Stop();
            randomBookArrive.Dispose();

            randomClientArrive.Stop();
            randomClientArrive.Dispose();

            pendingBookArrive.Stop();
            pendingBookArrive.Dispose();
        }

        // Событие остановки игры по таймеру
        private static void stopGameEvent(Object source, ElapsedEventArgs e) {
            isGameStarted = false;
        }

        // Событие добавление в очередь рандомной книги по таймеру
        private static void randomBookArriveEvent(Object source, ElapsedEventArgs e) {
            booksArrivedQueue.Enqueue(generateRandomBook(true));
        }

        // Событие добавление в очерель нового клиента по таймеру
        private static void randomClientArriveEvent(Object source, ElapsedEventArgs e) {
            clientsQueue.Enqueue(new Client(myShop.GetRandom(), labels, authors, genres));
            if (clientsQueue.Count > maxClientsQueue[curGameDifficulty]) {
                isGameStarted = false;
            }
        }

        // Событие добавление в очередь книги из очереди добавленных книг по таймеру
        private static void pendingBookArriveEvent(Object source, ElapsedEventArgs e) {
            booksArrivedQueue.Enqueue(booksPendingQueue.Dequeue());
        }

        // Проверка на правильность ввода
        public static string checkInput(string text, string alphabet, bool isNumber) {
            String newText = "";
            foreach (char letter in text)
            {
                if (alphabet.Contains(char.ToUpper(letter)))
                {
                    newText += letter;
                }
            }
            if (newText != "" && isNumber)
            {
                if (!MyClassLibrary.isNumber(newText))
                {
                    newText = Int32.MaxValue.ToString();
                }
                else
                {
                    newText = Convert.ToInt32(newText).ToString();
                }
            }
            return newText;
        }

        // Генерация книги с рандомными данными
        public static Book generateRandomBook(bool absoluteRandom) {
            return new Book(-1, myShop.GetRandom(), labels, authors, genres, absoluteRandom);
        }

        // Проверка текста на число
        public static bool isNumber(string text)
        {
            try
            {
                Convert.ToInt32(text);
                return true;
            }
            catch { return false; }
        }

        // Внешне-доступные функции
        public static string[] GetLabels() { return labels; }
        public static string[] GetAuthors() { return authors; }
        public static string[] GetGenres() { return genres; }
        public static Shop GetShop() { return myShop; }
    }
}

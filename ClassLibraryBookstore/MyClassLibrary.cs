using System.Timers;
using System.Collections;

using lab3Lib;

namespace ClassLibraryBookstore
{
    public class MyClassLibrary
    {
        // Общие данные
        private static string[] labels;
        private static string[] authors;
        private static string[] genres;
        private static Shop myShop;

        // Конструктор
        public MyClassLibrary() {
            System.IO.File.WriteAllText("dataBase.txt", "");
            loadData();
            myShop = new Shop();
        }

        // Загрузка данных из файлов
        private static void loadData() {
            string[] rawData = System.IO.File.ReadAllLines("booksData.txt");
            labels = new string[rawData.Length];
            authors = new string[rawData.Length];
            for (int i = 0; i < rawData.Length; i++) {
                string[] curLineS = rawData[i].Replace("\n", "").Split("|");

                labels[i] = curLineS[0];
                authors[i] = curLineS[1];
            }

            genres = System.IO.File.ReadAllText("genres.txt").Split(" ");
        }
        
        // Проверка на правильность ввода
        public static string checkInput(string text, string alphabet, bool isNumber_) {
            String newText = "";
            foreach (char letter in text)
            {
                if (alphabet.Contains(char.ToUpper(letter)))
                {
                    newText += letter;
                }
            }
            if (newText != "" && isNumber_)
            {
                if (!isNumber(newText))
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

        public static bool isBookValid(Book book)
        {
            return myShop.IsBookValid(book);
        }

        // Генерация книги с рандомными данными
        public static Book generateRandomBook(bool absoluteRandom) {
            Book newBook = new Book(myShop.GetLastBookId(), myShop.GetRandom(), labels, authors, genres, absoluteRandom);
            return newBook;
        }

        public static Client generateRandomClient()
        {
            return new Client(myShop.GetRandom(), labels, authors, genres);
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

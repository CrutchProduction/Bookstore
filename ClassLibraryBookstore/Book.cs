using System.Runtime;
using System.Security.Policy;

namespace lab3Lib;

public class Book {
    // Данные о книге
    private const string mistakesAlphabet = "qwertyuiopasdfghjklzxcvbnm";
    private string name;
    private string author;
    private string genre;
    private int id;
    private int pageAmount;
    private int price;
    private int copyId;
    private bool isFake;
    private bool isRandomized;

    // Конструктор
    public Book(string name, string author, string genre, int id, int pageAmount, int price, Random rnd) {
        if (genre == "ZOV") {
            this.name = "Конституция";
            this.author = "Владимир Владимирович Путин";
            this.genre = "ZOV";
            this.id = 67;
            this.pageAmount = 96;
            this.price = 87;
        } else {
            this.name = name;
            this.author = author;
            this.genre = genre;
            this.id = id;
            this.pageAmount = pageAmount;
            this.price = price;
        }
        this.isFake = false;
        this.isRandomized = false;
    }

    // Конструктор для рандомной генерации
    public Book(int id, Random rnd, string[] labels, string[] authors, string[] genres, bool absoluteRandom) {
        this.id = id;
        if (!absoluteRandom) {
            RandomGenerate(rnd, labels, authors, genres);
        } else {
            AbsoluteRandomGenerate(rnd, labels, authors, genres);
        }
        this.isRandomized = true;
    }

    // Генерация рандомной правильной книги
    private void RandomGenerate(Random rnd, string[] labels, string[] authors, string[] genres) {
        int index = rnd.Next(labels.Length);
        this.name = labels[index];
        this.author = authors[index];
        this.genre = genres[rnd.Next(genres.Length)];
        this.pageAmount = rnd.Next(15, 1489);
        this.price = rnd.Next(200, 1500);
    }

    // Генерация рандомной неправильной книги
    private void AbsoluteRandomGenerate(Random rnd, string[] labels, string[] authors, string[] genres) {
        bool shouldMakeMistake = rnd.Next(100) <= 43;
        if (!shouldMakeMistake) {
            RandomGenerate(rnd, labels, authors, genres);
        } else {
            int mistakeType = rnd.Next(2);
            switch (mistakeType) {
                case 0:
                    int nameIndex = rnd.Next(labels.Length);
                    this.name = labels[nameIndex];
                    int authorIndex = rnd.Next(authors.Length);
                    while (authorIndex == nameIndex) {
                        authorIndex = rnd.Next(authors.Length);
                    }
                    this.author = authors[authorIndex];
                    this.genre = genres[rnd.Next(genres.Length)];
                    this.pageAmount = rnd.Next(15, 1489);
                    this.price = rnd.Next(200, 1500);
                    break;
                case 1:
                    RandomGenerate(rnd, labels, authors, genres);
                    string bookNewName = (string) this.name.Clone();
                    int mistakesAmount = rnd.Next(4) + 1;
                    int mistakesMade = 0;
                    int i = 0;
                    while (mistakesMade != mistakesAmount && i < this.name.Length * 2) {
                        int letterId = rnd.Next(bookNewName.Length);
                        char[] bookNewNameArray = bookNewName.ToCharArray();
                        if (bookNewNameArray[letterId] == this.name.ToCharArray()[letterId]) {
                            if (Char.ToLower(bookNewNameArray[letterId]) != 'е' && bookNewNameArray[letterId] != ' ' && !Char.IsNumber(bookNewNameArray[letterId])) {
                                bookNewNameArray[letterId] = mistakesAlphabet[rnd.Next(mistakesAlphabet.Length)];
                                mistakesMade++;
                            }
                        }
                        bookNewName = string.Join("", bookNewNameArray);
                        i++;
                    }
                    this.name = (string) bookNewName.Clone();
                    break;
            }
            this.isFake = true;
        }
    }

    // Внешне-доступные функции
    public void SetCopyId(int copyId) { this.copyId = copyId; }
    public string GetName(bool withCopyId) { 
        if (withCopyId && this.copyId != 1) return this.name + " " + this.copyId; 
        return this.name;
    }
    public string GetAuthor() { return this.author; }
    public string GetGenre() { return this.genre; }
    public int GetId() { return this.id; }
    public int GetPageAmount() { return this.pageAmount; }
    public int GetPrice() { return this.price; }
    public int GetCopyId() { return this.copyId; }
    public bool IsFake() { return this.isFake; }
    public bool IsRandomized() { return this.isRandomized; }
}

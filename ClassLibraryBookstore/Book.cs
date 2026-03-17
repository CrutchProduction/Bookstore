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
        this.isRandomized = true;
        if (!absoluteRandom) {
            RandomGenerate(rnd, labels, authors, genres);
        } else {
            AbsoluteRandomGenerate(rnd, labels, authors, genres);
        }
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
        bool shouldMakeMistake = rnd.Next(100) <= 57;
        if (!shouldMakeMistake) {
            RandomGenerate(rnd, labels, authors, genres);
        } else {
            int mistakeType = rnd.Next(2);
            switch (mistakeType) {
                case 0:
                    int nameIndex = rnd.Next(labels.Length);
                    this.name = labels[nameIndex];
                    int authorIndex = rnd.next(authors.Length);
                    while (authorIndex == nameIndex) {
                        authorIndex = rnd.next(authors.Length);
                    }
                    this.author = authors[authorIndex];
                    this.genre = genres[rnd.Next(genres.Length)];
                    this.pageAmount = rnd.Next(15, 1489);
                    this.price = rnd.Next(200, 1500);
                    break;
                case 1:
                    RandomGenerate(rnd, labels, authors, genres);
                    string bookNewName = this.name.Clone();
                    int mistakesAmount = rnd.Next((int) this.name.Length / 2);
                    int mistakesMade = 0;
                    int i = 0;
                    while (mistakesMade != mistakesAmount && i < this.name.Length * 2) {
                        int letterId = rnd.Next(bookNewName.Length);
                        char[] bookNewNameArray = bookNewName.ToCharArray();
                        if (bookNewNameArray[letterId] == this.name.ToCharArray()[letterId]) {
                            if (Char.ToLower(bookNewNameArray[letterId]) != 'е' && !Char.IsNumber(bookNewNameArray[letterId])) {
                                bookNewNameArray[letterId] = mistakesAlphabet[rnd.Next(mistakesAlphabet.Length)];
                                mistakesMade++;
                            }
                        }
                        i++;
                    }
                    this.name = bookNewName.Clone();
                    break;
            }
            isFake = true;
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
}

using System.Runtime;
using System.Security.Policy;

namespace lab3Lib;

public class Book {
    private string name;
    private string author;
    private string genre;
    private int id;
    private int pageAmount;
    private int price;
    private int copyId;

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
    }

    // Конструктор для рандомной генерации
    public Book(int id, Random rnd) {
        this.id = id;
        RandomGenerate(rnd);
    }

    // Рандомная генерация книги
    private void RandomGenerate(Random rnd) {
        int gender = rnd.Next(2);
        string[] firstNames;
        string[] lastNames;
        if (gender == 0) {
            firstNames = System.IO.File.ReadAllText("firstNamesM.txt").Split(" ");
            lastNames = System.IO.File.ReadAllText("lastNamesM.txt").Split(" ");
        } else
        {
            firstNames = System.IO.File.ReadAllText("firstNamesF.txt").Split(" ");
            lastNames = System.IO.File.ReadAllText("lastNamesF.txt").Split(" ");
        }
        string[] nameParts = System.IO.File.ReadAllText("nameParts.txt").Split(",");
        string[] nameEndings = System.IO.File.ReadAllText("nameEndings.txt").Split(",");
        string[] genres = System.IO.File.ReadAllText("genres.txt").Split(" ");

        this.author += firstNames[rnd.Next(firstNames.Length)] + " " + lastNames[rnd.Next(lastNames.Length)];
        this.name += nameParts[rnd.Next(nameParts.Length)] + " " + nameEndings[rnd.Next(nameEndings.Length)];
        this.genre = genres[rnd.Next(genres.Length)];
        this.pageAmount = rnd.Next(15, 1489);
        this.price = rnd.Next(200, 6767);
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
}

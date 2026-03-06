using System.Runtime;

namespace lab3Lib;

public class Book {
    private string name;
    private string author;
    private string genre;
    private int id;
    private int pageAmount;
    private int price;

    public Book(string name, string author, string genre, int id, int pageAmount, int price) {
        this.name = name;
        this.author = author;
        this.genre = genre;
        this.id = id;
        this.pageAmount = pageAmount;
        this.price = price;
    }

    public Book(int id) {
        this.id = id;
        RandomGenerate();
    }

    private void RandomGenerate() {
        Random rnd = new Random((int) DateTimeOffset.UtcNow.ToUnixTimeSeconds());
        string[] firstNames = System.IO.File.ReadAllText("firstNames.txt").Split(" ");
        string[] lastNames = System.IO.File.ReadAllText("lastNames.txt").Split(" ");
        string[] nameParts = System.IO.File.ReadAllText("nameParts.txt").Split(",");
        string[] nameEndings = System.IO.File.ReadAllText("nameEndings.txt").Split(",");
        string[] genres = System.IO.File.ReadAllText("genres.txt").Split(" ");

        this.author += firstNames[rnd.Next(firstNames.Length)] + " " + lastNames[rnd.Next(lastNames.Length)];
        this.name += nameParts[rnd.Next(nameParts.Length)] + " " + nameEndings[rnd.Next(nameEndings.Length)];
        this.genre = genres[rnd.Next(genres.Length)];
        this.pageAmount = rnd.Next(15, 1489);
        this.price = rnd.Next(200, 6767);
    }

    public void SetNewName(string name) { this.name = name; }

    public string GetName() { return this.name; }
    public string GetAuthor() { return this.author; }
    public string GetGenre() { return this.genre; }
    public int GetId() { return this.id; }
    public int GetPageAmount() { return this.pageAmount; }
    public int GetPrice() { return this.price; }
}

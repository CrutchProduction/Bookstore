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
        string[] firstNames = new string[] {"Pelagiya", "Nelli", "Lazar", "Olya", "Alex", "Evgeniy", "Dorofey", "Lyuba", "Glikeriya", "Snezhana", "Lyuba", "Feodor", "Roma", "Abort", "Yelisey", "Evelina", "Irakliy", "Diana", "Yaroslav", "Taisiya"};
        string[] lastNames = new string[] {"Golubev", "Nikitina", "Sobol", "Naoumova", "Alekseyev", "Mikhailova", "Sokolof", "Mikhaylov", "Fedotov", "Kuzmina", "Mikhailov", "Gerasimova", "Ivankova", "Volkov", "Antonov", "Naoumova", "Krupin", "Matveeva", "Krupina", "Trifonov"};
        string[] nameParts = new string[] {"Rain", "The Titan", "Winged", "Six", "The Beast", "Moons", "The Hollow", "The Plague", "Wild", "Prince's", "The Starless", "Xeno", "Taste", "Day", "Enemy", "Case"};
        string[] nameEndings = new string[] {"of Wolves", "in the Gorge", "Clock", "Seven", "in the Glass", "of Artemis", "Piano", "of the Plant People", "and Wicked", "of the Legacy", "of Prophecy", "of Exile", "of Algorab", "of the Unnatural Jury", "of Silence", "of the Winged Goose"};
        string[] genres = new string[] {"Romance", "Fantasy", "Science Fiction", "Thriller", "Mystery", "Horror", "Historical Fiction", "Biography", "History", "Memoir"};

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

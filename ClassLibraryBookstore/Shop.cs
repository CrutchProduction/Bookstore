using System.Runtime;

namespace lab3Lib;

public class Shop {
    private BookShelf[] shelfs;
    private int balance;
    private int maxShelfs;
    private int lastBookId;
    private Random rnd;

    // Конструктор
    public Shop() {
        this.rnd = new Random((int) DateTimeOffset.UtcNow.ToUnixTimeSeconds());
        this.maxShelfs = this.rnd.Next(4, 11);
        this.shelfs = new BookShelf[this.maxShelfs];
        this.balance = this.rnd.Next(67, 676);
        for (int i = 0; i < this.maxShelfs; i++) {
            this.shelfs[i] = new BookShelf(this.rnd);
        }
    }

    // Добавление книги в магазин
    public void AddBook(string name, string author, string genre, int pageAmount, int price) {
        BookShelf curShelf = FindBookShelf(genre);
        if (curShelf != null) {
            Book newBook = new Book(name, author, genre, this.lastBookId, pageAmount, price, this.rnd);
            CheckBookName(newBook);
            curShelf.AddBook(newBook);
            if (this.lastBookId != Int32.MaxValue) {
                this.lastBookId++;
            } else
            {
                this.lastBookId = 0;
            }
        }
    }

    // Проверка книги на копии названия
    public void CheckBookName(Book book) {
        int multiplier = 1;
        foreach (BookShelf shelf in this.shelfs) {
            foreach (Book book_ in shelf.GetBooks()) {
                if (book_ != null) {
                    if (book_.GetName(false).StartsWith(book.GetName(false))) {
                        multiplier++;
                    }
                }
            }
        }
        book.SetCopyId(multiplier);
    }

    // Поиск шкафа с заданным жанром
    public BookShelf FindBookShelf(string genre) {
        foreach (BookShelf shelf in this.shelfs) {
            if (shelf.GetGenre() == genre) {
                return shelf;
            }
        }
        foreach (BookShelf shelf in this.shelfs) {
            if (shelf.GetGenre() == "") {
                return shelf;
            }
        }
        return null;
    }

    // Внешне-доступные функции
    public Random GetRandom() { return this.rnd; }
    public void AddBalance(int income) { this.balance += income; }
    public BookShelf[] GetShelfs() { return this.shelfs; }
    public int GetBalance() { return this.balance; }
    public int GetLastBookId() { return this.lastBookId; }
}

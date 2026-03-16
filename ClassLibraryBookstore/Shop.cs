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
        this.maxShelfs = this.rnd.Next(4, 10);
        this.shelfs = new BookShelf[11];
        this.balance = this.rnd.Next(67, 676);
        for (int i = 0; i < this.maxShelfs; i++) {
            this.shelfs[i] = new BookShelf(this.rnd);
        }
    }

    // Добавление книги в магазин
    public void AddBook(string name, string author, string genre, int pageAmount, int price) {
        BookShelf curShelf;
        if (genre != "ZOV")
        {
            curShelf = FindBookShelf(genre);
        } else
        {
            curShelf = new BookShelf(this.rnd);
            this.shelfs[10] = curShelf;
        }

        if (curShelf != null)
        {
            Book newBook = new Book(name, author, genre, this.lastBookId, pageAmount, price, this.rnd);
            CheckBookName(newBook);
            curShelf.AddBook(newBook);
            if (this.lastBookId != Int32.MaxValue)
            {
                this.lastBookId++;
            }
            else
            {
                this.lastBookId = 0;
            }
        }
    }

    // Проверка книги на копии названия
    public void CheckBookName(Book book) {
        int maxCopyId = 0;
        foreach (BookShelf shelf in this.shelfs) {
            if (shelf != null) {
                foreach (Book book_ in shelf.GetBooks())
                {
                    if (book_ != null)
                    {
                        if (book_.GetName(false).StartsWith(book.GetName(false)))
                        {
                            if (maxCopyId < book_.GetCopyId())
                            {
                                maxCopyId = book_.GetCopyId();
                            }
                        }
                    }
                }
            }
        }
        book.SetCopyId(maxCopyId + 1);
    }

    // Поиск шкафа с заданным жанром
    public BookShelf FindBookShelf(string genre) {
        foreach (BookShelf shelf in this.shelfs) {
            if (shelf != null) {
                if (shelf.GetGenre() == genre)
                {
                    return shelf;
                }
            }
        }
        foreach (BookShelf shelf in this.shelfs) {
            if (shelf != null) {
                if (shelf.GetGenre() == "")
                {
                    return shelf;
                }
            }
        }
        return null;
    }

    // Внешне-доступные функции
    public int GetMaxShelfs() { return this.maxShelfs; }
    public Random GetRandom() { return this.rnd; }
    public void AddBalance(int income) { this.balance += income; }
    public BookShelf[] GetShelfs() { return this.shelfs; }
    public int GetBalance() { return this.balance; }
    public int GetLastBookId() { return this.lastBookId; }
}

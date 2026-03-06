using System.Runtime;

namespace lab3Lib;

public class Shop {
    private BookShelf[] shelfs;
    private int balance;
    private int maxShelfs;
    private int lastBookId;

    public Shop() {
        Random rnd = new Random((int) DateTimeOffset.UtcNow.ToUnixTimeSeconds());
        this.maxShelfs = rnd.Next(4, 11);
        this.shelfs = new BookShelf[this.maxShelfs];
        this.balance = rnd.Next(67, 676);
        for (int i = 0; i < this.maxShelfs; i++) {
            this.shelfs[i] = new BookShelf();
        }
    }

    public void AddBook(string name, string author, string genre, int pageAmount, int price) {
        BookShelf curShelf = FindBookShelf(genre);
        if (curShelf != null) {
            Book newBook = new Book(name, author, genre, this.lastBookId, pageAmount, price);
            CheckBookName(newBook);
            curShelf.AddBook(newBook);
            this.lastBookId++;
        }
    }

    public void AddBook() {
        Book newBook = new Book(this.lastBookId);
        BookShelf curShelf = FindBookShelf(newBook.GetGenre());
        if (curShelf != null) {
            CheckBookName(newBook);
            curShelf.AddBook(newBook);
            this.lastBookId++;
        }
    }

    public void CheckBookName(Book book) {
        int multiplier = 1;
        foreach (BookShelf shelf in this.shelfs) {
            foreach (Book book_ in shelf.GetBooks()) {
                if (book_ != null) {
                    if (book_.GetName().StartsWith(book.GetName())) {
                        multiplier++;
                    }
                }
            }
        }
        if (multiplier != 1) {
            book.SetNewName(book.GetName() + " " + multiplier);
        }
    }

    public void SellShelf(int id) {
        BookShelf curShelf = this.shelfs[id];
        foreach (Book book in (Book[]) curShelf.GetBooks().Clone()) {
            this.balance += curShelf.SellBook(book);
        }
    }

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

    public BookShelf[] GetShelfs() { return this.shelfs; }
    public int GetBalance() { return this.balance; }
}

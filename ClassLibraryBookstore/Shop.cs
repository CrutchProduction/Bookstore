using System.Runtime;

namespace lab3Lib;

public class Shop {
    // Данные о магазине
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
        this.balance = 1100;
        for (int i = 0; i < this.maxShelfs; i++) {
            this.shelfs[i] = new BookShelf(this.rnd);
        }
    }

    // Проверка книги на копии названия
    public void CheckBookName(Book book) {
        int amount = 0;
        foreach (BookShelf shelf in this.shelfs) {
            if (shelf != null) {
                foreach (Book book_ in shelf.GetBooks())
                {
                    if (book_ != null)
                    {
                        if (book_.GetName(false).StartsWith(book.GetName(false)) && book_.GetAuthor() == book.GetAuthor())
                        {
                            amount++;
                        }
                    }
                }
            }
        }
        int[] copySequence = new int[amount];
        int i = 0;
        foreach (BookShelf shelf in this.shelfs) {
            if (shelf != null) {
                foreach (Book book_ in shelf.GetBooks()) {
                    if (book_ != null) {
                        if (book_.GetName(false).StartsWith(book.GetName(false)) && book_.GetAuthor() == book.GetAuthor()) {
                            copySequence[i] = book_.GetCopyId(); 
                            i++;
                        }
                    }
                }
            }
        }
        Array.Sort(copySequence);
        if (copySequence.Length >= 1 && copySequence[0] != 1) {
            book.SetCopyId(1);
            return;
        }
        for (int j = 0; j < amount - 1; j++) {
            if (copySequence[j + 1] - copySequence[j] != 1) {
                book.SetCopyId(copySequence[j] + 1);
                return;
            }
        }
        book.SetCopyId(copySequence.Length + 1);
    }

    // Поиск шкафа с заданным жанром
    public BookShelf FindBookShelf(string genre) {
        foreach (BookShelf shelf in this.shelfs) {
            if (shelf != null) {
                if (shelf.GetGenre() == genre && !shelf.IsFull() )
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
    public void AddBalance(int income) { this.balance += income; }
    public void AddLastBookId() { this.lastBookId++; }
    public void AddZOVShelf(BookShelf shelf) { this.shelfs[10] = shelf; }
    public void RemoveZOVShelf() { this.shelfs[10] = null; }
    public int GetMaxShelfs() { return this.maxShelfs; }
    public Random GetRandom() { return this.rnd; }
    public BookShelf[] GetShelfs() { return this.shelfs; }
    public int GetBalance() { return this.balance; }
    public int GetLastBookId() { return this.lastBookId; }
}

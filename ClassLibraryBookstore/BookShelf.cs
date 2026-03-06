using System.Runtime;

namespace lab3Lib;

public class BookShelf {
    private string genre;
    private Book[] books;
    private int lastBookId;
    private int size;

    public BookShelf() {
        Random rnd = new Random((int) DateTimeOffset.UtcNow.ToUnixTimeSeconds());
        this.size = rnd.Next(3, 15);
        this.books = new Book[this.size];
        this.genre = "";
        this.lastBookId = 0;
    }

    public void AddBook(Book book) {
        if (this.size - 1 <= this.lastBookId) {
            return;
        }
        
        this.books[this.lastBookId] = book;
        this.lastBookId++;

        if (this.books.Length == 1) {
            this.genre = book.GetGenre();
        }
    }

    public void RemoveBook(Book book) {
        if (Array.IndexOf(this.books, book) == -1) return;
        this.books[Array.IndexOf(this.books, book)] = null;
        Book[] booksBuffer = (Book[]) this.books.Clone();
        int i = 0;
        foreach (Book book_ in this.books) {
            if (book_ != null) {
                booksBuffer[i] = book_;
                i++;
            }
        }
        this.books = (Book[]) booksBuffer.Clone();
        this.lastBookId--;

        if (this.books.Length == 0) {
            this.genre = "";
        }
    }

    public Book SearchBook(string name) {
        foreach (Book book in this.books) {
            if (book.GetName() == name) {
                return book;
            }
        }
        return null;
    }

    public Book SearchBook(int id) {
        foreach (Book book in this.books) {
            if (book.GetId() == id) {
                return book;
            }
        }
        return null;
    }

    public int SellBook(Book book) {
        RemoveBook(book);
        return book.GetPrice();
    }

    public Book[] GetBooks() { return this.books; }
    public string GetGenre() { return this.genre; }
}

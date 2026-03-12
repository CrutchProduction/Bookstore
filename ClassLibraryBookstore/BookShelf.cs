using System.Runtime;

namespace lab3Lib;

public class BookShelf {
    private string genre;
    private Book[] books;
    private int lastBookId;
    private int size;

    // Конструктор
    public BookShelf(Random rnd) {
        this.size = rnd.Next(8, 16);
        this.books = new Book[this.size];
        this.genre = "";
        this.lastBookId = 0;
    }

    // Добавление книги в шкаф
    public void AddBook(Book book) {
        if (this.size - 1 <= this.lastBookId) {
            return;
        }
        
        this.books[this.lastBookId] = book;
        this.lastBookId++;

        this.genre = book.GetGenre();
    }

    // Удаление книги из шкафа
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
        for (int j = i;  j < booksBuffer.Length; j++)
        {
            booksBuffer[j] = null;
        }
        this.books = (Book[]) booksBuffer.Clone();
        this.lastBookId--;

        if (this.books[0] == null) {
            this.genre = "";
        }
    }

    // Поиск книги в шкафе по названию + строковому айди
    public Book SearchBook(string name) {
        foreach (Book book in this.books) {
            if (book != null && (book.GetId().ToString() == name || book.GetName(true).Contains(name))) {
                return book;
            }
        }
        return null;
    }

    // Поиск книги в шкафе по численному айди
    public Book SearchBook(int id) {
        foreach (Book book in this.books) {
            if (book != null && (book.GetId() == id)) {
                return book;
            }
        }
        return null;
    }

    // Продажа книги
    public int SellBook(Book book) {
        RemoveBook(book);
        return book.GetPrice();
    }

    // Внешне-доступные функции
    public Book[] GetBooks() { return this.books; }
    public string GetGenre() { return this.genre; }
}

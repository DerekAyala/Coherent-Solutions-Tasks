using Task_5._2;

class Program
{
    static void Main()
    {
        Book book1 = new Book("Introduction to C#", new DateTime(2022, 1, 1), new List<string> { "Author1", "Author2" });
        Book book2 = new Book("Advanced C# Programming", new DateTime(2022, 2, 1), new List<string> { "Author1", "Author3" });
        Book book3 = new Book("C# Best Practices", new DateTime(2022, 3, 1), new List<string> { "Author2", "Author3" });
        Catalog catalog = new Catalog();

        // Agregar libros al catálogo
        catalog.AddBook("123-4-56-789012-3", book1);
        catalog.AddBook("9876543210123", book2);
        catalog.AddBook("111-2-33-444567-8", book3);

        // Pruebas de los métodos
        Console.WriteLine("Libros ordenados alfabéticamente:");
        var sortedTitles = catalog.GetSortedTitles();
        PrintList(sortedTitles);

        Console.WriteLine("\nLibros del autor 'Author2':");
        var booksByAuthor2 = catalog.GetBooksByAuthor("Author2");
        PrintList(booksByAuthor2);

        Console.WriteLine("\nNúmero de libros por autor:");
        var authorBookCounts = catalog.GetAuthorBookCounts();
        PrintAuthorBookCounts(authorBookCounts);
    }

    static void PrintList<T>(IEnumerable<T> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    static void PrintAuthorBookCounts(IEnumerable<(string Author, int BookCount)> counts)
    {
        foreach (var (author, count) in counts)
        {
            Console.WriteLine($"{author}: {count} libros");
        }
    }
}
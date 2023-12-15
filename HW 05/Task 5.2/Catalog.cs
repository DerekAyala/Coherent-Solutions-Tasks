using System;
using System.Text.RegularExpressions;

namespace Task_5._2
{
    public class Catalog
    {
        private List<Tuple<string, Book>> books;
        public Catalog()
        {
            books = new List<Tuple<string, Book>>();
        }

        public void AddBook(string isbn, Book book)
        {
            if (string.IsNullOrEmpty(isbn))
            {
                throw new ArgumentException("El ISBN no puede estar vacío o ser nulo.");
            }

            // Validar el formato del ISBN
            if (!IsValidISBNFormat(isbn))
            {
                throw new ArgumentException("El formato del ISBN no es válido.");
            }

            isbn = NormalizeISBN(isbn);
            books.Add(Tuple.Create(isbn, book));
        }

        private bool IsValidISBNFormat(string isbn)
        {
            // Expresión regular para el formato del ISBN
            string isbnPattern = @"^\d{3}-\d-\d{2}-\d{6}-\d$|^\d{13}$";

            return Regex.IsMatch(isbn, isbnPattern);
        }


        private string NormalizeISBN(string isbn)
        {
            // Eliminar guiones y espacios en blanco
            return isbn.Replace("-", "").Replace(" ", "");
        }

        public Book? GetBookByISBN(string isbn)
        {
            if (!IsValidISBNFormat(isbn))
            {
                throw new ArgumentException("El formato del ISBN no es válido.");
            }
            isbn = NormalizeISBN(isbn);
            return books.FirstOrDefault(tuple => tuple.Item1 == isbn)?.Item2;
        }

        public IEnumerable<string> GetSortedTitles()
        {
            return books.Select(tuple => tuple.Item2.Title).OrderBy(title => title);
        }

        public IEnumerable<Book> GetBooksByAuthor(string authorName)
        {
            return books
                .Where(tuple => tuple.Item2.Authors.Contains(authorName))
                .OrderBy(tuple => tuple.Item2.PublicationDate)
                .Select(tuple => tuple.Item2);
        }

        public IEnumerable<(string Author, int BookCount)> GetAuthorBookCounts()
        {
            return books
                .SelectMany(tuple => tuple.Item2.Authors, (tuple, author) => author)
                .GroupBy(author => author)
                .Select(group => (Author: group.Key, BookCount: group.Count()));
        }
    }
}


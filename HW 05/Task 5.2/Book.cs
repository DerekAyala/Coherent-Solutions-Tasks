using System;
namespace Task_5._2
{
    public class Book
    {
        public string Title { get; }
        public DateTime? PublicationDate { get; }
        public HashSet<string> Authors { get; }

        public Book(string title, DateTime? publicationDate, IEnumerable<string> authors)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Title cannot be empty or null.");
            }

            Title = title;
            PublicationDate = publicationDate;
            Authors = new HashSet<string>(authors ?? Array.Empty<string>());
        }
    }
}


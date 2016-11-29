using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
        public Library(string name)
        {
            Name = name;
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public List<Book> BooksByAuthor(string author)
        {
            List<Book> searchResults = new List<Book>();

            foreach (Book book in Books)
            {
                if (book.Author.IndexOf(author) != -1)
                {
                    searchResults.Add(book);
                }
            }
            return searchResults;
        }

        public string BookInformation(string isbn)
        {
            List<string> bookInfos = new List<string>();

            foreach (Book book in Books)
            {
                if (book.ISBN == isbn)
                {
                    StringBuilder sb = new StringBuilder();

                    sb.Append("Title: " + book.Title + "\n");
                    sb.Append("Author: " + book.Author + "\n");
                    sb.Append("Publisher: " + book.Publisher + "\n");
                    sb.Append("Release date: " + book.ReleaseDate.ToString("dd/MM/yyyy") + "\n");
                    sb.Append("ISBN number: " + book.ISBN + "\n");

                    return sb.ToString();
                }
            }
            return null;
        }

        public void DeleteBook(string isbn)
        {
            foreach (Book book in Books)
            {
                if (book.ISBN == isbn)
                {
                    Books.Remove(book);
                    return;
                }
            }
        }
    }
}

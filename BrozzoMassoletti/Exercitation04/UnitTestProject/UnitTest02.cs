using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise02;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest02
    {
        public Library testLibrary;

        [TestInitialize]
        public void InitializeLibrary()
        {
            testLibrary = new Library("Test Library");

            testLibrary.AddBook(new Book("1984", "George Orwell", "Secker & Warburg", new DateTime(1949, 6, 8), "0-547-24964-0"));
            testLibrary.AddBook(new Book("I, Robot", "Isaac Asimov", "Gnome Press", new DateTime(1950, 12, 2), "0-586-02532-4"));
            testLibrary.AddBook(new Book("Harry Potter and the Philosopher's Stone", "J. K. Rowling", "Bloomsbury", new DateTime(1997, 6, 26), "0-7475-3269-9"));
            testLibrary.AddBook(new Book("The Shining", "Stephen King", "Doubleday", new DateTime(1977, 1, 28), "978-0-385-12167-5"));
            testLibrary.AddBook(new Book("Misery", "Stephen King", "Viking", new DateTime(1987, 6, 8), "978-0-670-81364-3"));
        }
        
        [TestMethod]
        public void CheckBooksInfo()
        {
            string[] expectedInfo = new string[5];
            string[] bookInfo = new string[5];

            expectedInfo[0] = "Title: 1984\nAuthor: George Orwell\nPublisher: Secker & Warburg\nRelease date: 08/06/1949\nISBN number: 0-547-24964-0\n";
            expectedInfo[1] = "Title: I, Robot\nAuthor: Isaac Asimov\nPublisher: Gnome Press\nRelease date: 02/12/1950\nISBN number: 0-586-02532-4\n";
            expectedInfo[2] = "Title: Harry Potter and the Philosopher's Stone\nAuthor: J. K. Rowling\nPublisher: Bloomsbury\nRelease date: 26/06/1997\nISBN number: 0-7475-3269-9\n";
            expectedInfo[3] = "Title: The Shining\nAuthor: Stephen King\nPublisher: Doubleday\nRelease date: 28/01/1977\nISBN number: 978-0-385-12167-5\n";
            expectedInfo[4] = "Title: Misery\nAuthor: Stephen King\nPublisher: Viking\nRelease date: 08/06/1987\nISBN number: 978-0-670-81364-3\n";
            bookInfo[0] = testLibrary.BookInformation("0-547-24964-0");
            bookInfo[1] = testLibrary.BookInformation("0-586-02532-4");
            bookInfo[2] = testLibrary.BookInformation("0-7475-3269-9");
            bookInfo[3] = testLibrary.BookInformation("978-0-385-12167-5");
            bookInfo[4] = testLibrary.BookInformation("978-0-670-81364-3");

            CollectionAssert.AreEqual(expectedInfo, bookInfo);
        }

        [TestMethod]
        public void DeleteBooks()
        {
            bool foundNotDeleted = false;
            foreach (Book book in testLibrary.BooksByAuthor("Stephen King"))
            {
                testLibrary.DeleteBook(book.ISBN);
            }
            foreach (Book book in testLibrary.Books)
            {
                if (book.Author == "Stephen King")
                {
                    foundNotDeleted = true;
                    break;
                }
            }
            Assert.IsFalse(foundNotDeleted);
        }
    }
}

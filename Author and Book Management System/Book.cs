
using System.Threading.Channels;

namespace Author_and_Book_Management_System
{
    internal class Book
    {
        private string title;
        private int publicationYear;
        private string genre;

        public Book(string title, int publicationYear, string genre) { 
            this.title = title;
            this.publicationYear = publicationYear;
            this.genre = genre;
        }

        public void displayBookInfo() => Console.WriteLine($"Title:{this.title}, " +
            $"PublicationYear: {this.publicationYear}, Genre: {this.genre}");
    }
}

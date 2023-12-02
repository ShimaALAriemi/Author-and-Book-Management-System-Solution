
using System.Threading.Channels;

namespace Author_and_Book_Management_System
{
    internal class Author
    {
        private string authorName;
        private int birthYear;
        private string nationality;
        List<Book> books = new List<Book>();

        public Author(string authorName, int birthYear, string nationality)
        {
            this.authorName = authorName;
            this.birthYear = birthYear;
            this.nationality = nationality;

        }

        public string Name{
            get { return authorName; }
            set { authorName = value; }
            }
        public void displayBooks() {
            for (int i = 0; i < books.Count(); i++) { 
                Console.Write($"{i+1}. "); books[i].displayBookInfo();
            }
                }

        public void addBooks(Book book) => books.Add(book);

        public void displayAuthorInfo() => Console.WriteLine($"||Author:{this.authorName}\n" +
            $"||Year of Birt: {this.birthYear}\n||Nationality: {this.nationality}");

    }
}

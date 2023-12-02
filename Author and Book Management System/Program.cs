using System.Security.Cryptography;

namespace Author_and_Book_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Author and Book Management System!");

            Author author = getAuthorInfo();
            // author.displayAuthorInfo();

            Console.WriteLine($"\nAdding Books for {author.Name}:\n");

            getBookInfo(author);
            Console.WriteLine();
            getBookInfo(author);
            Console.WriteLine();
            getBookInfo(author);

            Console.WriteLine("\nDisplaying Books for J.K. Rowling:\n");
            author.displayBooks();
        }

        public static Author getAuthorInfo()
        {
            Console.Write("Author Information:\nName: ");
            string name = Console.ReadLine();

            Console.Write("Birth Year:");
            int birthYear;
            int.TryParse(Console.ReadLine(), out birthYear);

            Console.Write("Nationality:");
            string nationality = Console.ReadLine();

            return new Author(name, birthYear, nationality);
        }

        public static void getBookInfo(Author author)
        {
            
            
            Console.Write("Enter Book Title:");
            string title = Console.ReadLine();

            Console.Write("Enter Publication Year:");
            int publicationYear;
            int.TryParse(Console.ReadLine(), out publicationYear);

            Console.Write("Enter Genre:");
            string genre = Console.ReadLine();

            author.addBooks( new Book(title, publicationYear, genre));
        }
    }
}
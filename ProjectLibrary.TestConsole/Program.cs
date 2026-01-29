using ProjectLibrary.DAL.Entities;
using ProjectLibrary.DAL.Services;

namespace ProjectLibrary.TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookService service = new BookService();

            IEnumerable<Book> library = service.Get();

            foreach (Book book in library)
            {
                Console.WriteLine($"\"{book.Title}\" écrit par {book.Author}");
            }
        }
    }
}
